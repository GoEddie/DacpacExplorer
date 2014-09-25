using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Pages
{
    public partial class Explorer : Page
    {
        private readonly TSqlModel _model;
        private readonly RecursionGuard _recursionGuard = new RecursionGuard();

        public Explorer()
        {
            InitializeComponent();
            TreeView.SelectedItemChanged += TreeView_SelectedItemChanged;

            var repository = ModelRepository.GetRepository();
            _model = repository.GetModel();

            var dacpacNode = AddRootTreeItem("Dacpac Properties");
            dacpacNode.Tag = new CachedObjectDisplay()
            {
                Properties = GetPropertiesDisplayForDacpac(),
                Script = ""
            };


            DisplayTopLevelNode("Tables", ModelSchema.Table);
            DisplayTopLevelNode("Views", ModelSchema.View);
            
            var programabililtyNode = AddRootTreeItem("Programmability");
            DisplayTopLevelNode(programabililtyNode, "Procedures", ModelSchema.Procedure);
            DisplayTopLevelNode(programabililtyNode, "Scalar Functions", ModelSchema.ScalarFunction);
            DisplayTopLevelNode(programabililtyNode, "Table-Valued Functions", ModelSchema.TableValuedFunction);
            DisplayTopLevelNode(programabililtyNode, "Database Triggers", ModelSchema.DatabaseDdlTrigger);
            DisplayTopLevelNode(programabililtyNode, "Server Triggers", ModelSchema.ServerDdlTrigger);
            DisplayTopLevelNode(programabililtyNode, "Assemblies", ModelSchema.Assembly);

            var securityNode = AddRootTreeItem("Security");
            DisplayTopLevelNode(securityNode, "Server Logins", ModelSchema.Login);
            DisplayTopLevelNode(securityNode, "Database Users", ModelSchema.User);
            DisplayTopLevelNode(securityNode, "Schemas", ModelSchema.Schema);
            DisplayTopLevelNode(securityNode, "Roles", ModelSchema.Role);

            Cursor = Cursors.Arrow;
        }

        void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Properties.Children.Clear();
            ScriptDisplay.Text = "";

            var item = e.NewValue as TreeViewItem;
            if (null == item)
            {
                return;
            }

            var display = item.Tag as CachedObjectDisplay;

            if (null == display)
                return;

            Properties.Children.Add(display.Properties);
            ScriptDisplay.Text = display.Script;

        }

        private void DisplayTopLevelNode(ItemsControl rootNode, string header, ModelTypeClass type)
        {
            var newNode = AddTreeItem(header, rootNode);

            var objects = _model.GetObjects(DacQueryScopes.All, type);

            foreach (var child in objects)
            {
                var childTreeNode = AddTreeItem(child.Name.ToString(), newNode);
                DisplayObject(header, child, childTreeNode);
            }    
        }

        private void DisplayTopLevelNode(string description, ModelTypeClass type)
        {
            DisplayTopLevelNode(TreeView, description, type);
        }

        private void DisplayObject(string rootNodeHeader, TSqlObject currentObject, TreeViewItem currentObjectTreeViewItem)
        {
            //Because we use recursion and we don't know what the model might give us we need to ensure we don't end
            //up in an infitnite loop
         //   if (!_recursionGuard.Add(rootNodeHeader, currentObject.Name.ToString(), currentObject))
        //        return;
            
            var properties = GetPropertiesDisplay(currentObject);
            var script = GetScript(currentObject);

            currentObjectTreeViewItem.Tag = new CachedObjectDisplay()
            {
                Properties = properties,
                Script = script
            };
            
            var childObjectTypes = new Dictionary<string, TreeViewItem>();

            DisplyChildObjects(rootNodeHeader, currentObjectTreeViewItem, currentObject.GetChildren(), childObjectTypes);           

        }


        private void DisplyChildObjects(string rootNodeHader, TreeViewItem currentObjectTreeViewItem, IEnumerable<TSqlObject> children, Dictionary<string, TreeViewItem> childObjectTypes)
        {
            foreach (var child in children.OrderBy(p=>p, new TSqlObjectComparer()))
            {
                var type = child.ObjectType.Name;
                var typeContainerHeader = GetContainerHeader(type);

                if (!childObjectTypes.ContainsKey(typeContainerHeader))
                {
                    var item = AddTreeItem(typeContainerHeader, currentObjectTreeViewItem);
                    childObjectTypes.Add(typeContainerHeader, item);
                }

                var childTreeViewItem = AddTreeItem(child.Name.ToString(), childObjectTypes[typeContainerHeader]);

                DisplayObject(rootNodeHader, child, childTreeViewItem);
            }
        }

        private static string GetContainerHeader(string type)
        {

            if (type.EndsWith("ex", StringComparison.OrdinalIgnoreCase))
                return type + "es";

            if (type.EndsWith("ty", StringComparison.OrdinalIgnoreCase))
                return type.Replace("ty", "ties");

            return type + "s";
            
        }

        private string GetScript(TSqlObject table)
        {
            var script = "";

            if (!table.TryGetScript(out script))
            {
                script = "Object doesn't have script, see top level object instead";
            }

            return script;
        }

        private UIElement GetPropertiesDisplay(TSqlObject item)
        {
            var panel = GetPropertiesDisplayPanel(item.Name.ToString());

            
            AddCustomProperties(item, panel);

            
            

            foreach (var property in item.ObjectType.Properties.OrderBy(p=>p.Name))
            {
                var val = property.GetValue<object>(item);
                if (val == null)
                {
                    val = "NULL";
                }

                var label = GetPropertyLabel(property.Name, val.ToString());

                panel.Children.Add(label);
            }

            return panel;
        }

        private void AddCustomProperties(TSqlObject item, StackPanel panel)
        {
            if (item.ObjectType == ModelSchema.Index)
            {
                AddPropertiesForIndex(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.Column)
            {
                AddPropertiesForColumn(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.PrimaryKeyConstraint)
            {
                AddPropertiesForPrimaryKey(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.ForeignKeyConstraint)
            {
                AddPropertiesForForeignKey(panel, item);
                return;
            }

            
        }

        private StackPanel GetPropertiesDisplayPanel(string name)
        {
            var panel = GetPropertiesPanel();

            var nameLabel = GetPropertiesNameLabel(name);
            panel.Children.Add(nameLabel);



            return panel;
        }



        private UIElement GetPropertiesDisplayForDacpac()
        {
            var panel = GetPropertiesDisplayPanel("Version: " +_model.Version);
            var options = _model.CopyModelOptions();

            foreach (var prop in options.GetType().GetProperties().OrderBy(p=>p.Name))
            {
                var val = prop.GetValue(options) as object;
                if (val == null)
                {
                    val = "NULL";
                }

                panel.Children.Add(GetPropertyLabel(prop.Name, val.ToString()));
            }

            return panel;
        }


        private void AddPropertiesForForeignKey(Panel panel, TSqlObject key)
        {
            foreach (var reference in key.GetReferencedRelationshipInstances(ForeignKeyConstraint.Columns))
            {
                panel.Children.Add(GetPropertyLabel("Column: ", reference.ObjectName.ToString()));
            }

            foreach (var reference in key.GetReferencedRelationshipInstances(ForeignKeyConstraint.ForeignTable))
            {
                panel.Children.Add(GetPropertyLabel("Foreign Table: ", reference.ObjectName.ToString()));
            }
            foreach (var reference in key.GetReferencedRelationshipInstances(ForeignKeyConstraint.ForeignColumns))
            {
                panel.Children.Add(GetPropertyLabel("Foreign Column: ", reference.ObjectName.ToString()));
            }

        }


        private void AddPropertiesForPrimaryKey(Panel panel, TSqlObject key)
        {
            foreach (var reference in key.GetReferencedRelationshipInstances(PrimaryKeyConstraint.Columns))
            {
                panel.Children.Add(GetPropertyLabel("Column: ", reference.ObjectName + " " + (reference.GetProperty<bool>(PrimaryKeyConstraint.ColumnsRelationship.Ascending) ? "ASC" : "DESC")));
            }
        }

        private void AddPropertiesForColumn(Panel panel, TSqlObject column)
        {
            var type = column.GetMetadata<ColumnType>(Column.ColumnType);
            
            panel.Children.Add(GetPropertyLabel("Column MetaType: ", type == ColumnType.Column ? "Standard Column" : type.ToString()));

            foreach (TSqlObject referenced in column.GetReferenced())
            {
                panel.Children.Add(GetPropertyLabel("Type: ", referenced.Name.ToString()));
            }

        }


        private void AddPropertiesForIndex(Panel panel, TSqlObject index)
        {

            foreach (var reference in index.GetReferencedRelationshipInstances(Index.Columns))
            {
                panel.Children.Add(GetPropertyLabel("Column: ", reference.ObjectName + " " + (reference.GetProperty<bool>(Index.ColumnsRelationship.Ascending) ? "ASC" : "DESC")));
            }

            if (index.GetReferencedRelationshipInstances(Index.IncludedColumns).Any())
            {
                foreach (var reference in index.GetReferencedRelationshipInstances(Index.IncludedColumns))
                {
                    panel.Children.Add(GetPropertyLabel("Included Column: ", reference.ObjectName.ToString()));
                }
            }
        }

        private static Label GetPropertyLabel(string name, string val)
        {
            var displayText = string.Format("{0} = {1}", name, val);

            var label = new Label();
            label.Content = displayText;
            return label;
        }

        private UIElement GetPropertiesNameLabel(string name)
        {
            var nameLabel = new Label();
            nameLabel.Content = name;
            nameLabel.Margin = new Thickness(0, 5, 0, 25);
            nameLabel.FontSize = 16.0;
            return nameLabel;
        }

        private static StackPanel GetPropertiesPanel()
        {
            var panel = new StackPanel {Orientation = Orientation.Vertical};
            panel.Margin = new Thickness(100, 25, 0, 0);
            return panel;
        }

        private TreeViewItem AddRootTreeItem(string header)
        {
            return AddTreeItem(header, TreeView);
        }

        private TreeViewItem AddTreeItem(string header, ItemsControl parent)
        {
            if (string.IsNullOrEmpty(header))
            {
                header = "Unnamed";
            }

            var item = new TreeViewItem() { Header = header };
            parent.Items.Add(item);
            return item;
        }
    }

    public class CachedObjectDisplay
    {
        public string Script { get; set; }
        public UIElement Properties { get; set; }
    }

    public class TSqlObjectComparer : IComparer<TSqlObject>
    {
        public int Compare(TSqlObject x, TSqlObject y)
        {
            return x.Name.ToString().CompareTo(y.Name.ToString());
        }
    }
}
