using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Pages
{
    /// <summary>
    /// Interaction logic for Explorer.xaml
    /// </summary>
    public partial class Explorer : Page
    {
        private readonly TSqlModel _model;

        public Explorer()
        {
            InitializeComponent();
            TreeView.SelectedItemChanged += TreeView_SelectedItemChanged;

            var repository = ModelRepository.GetRepository();
            _model = repository.GetModel();

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
                DisplayObject(child, childTreeNode);
            }    
        }

        private void DisplayTopLevelNode(string description, ModelTypeClass type)
        {
            DisplayTopLevelNode(TreeView, description, type);
        }

        private void DisplayObject(TSqlObject currentObject, TreeViewItem currentObjectTreeViewItem)
        {
            var properties = GetPropertiesDisplay(currentObject);
            var script = GetScript(currentObject);

            currentObjectTreeViewItem.Tag = new CachedObjectDisplay()
            {
                Properties = properties,
                Script = script
            };
            
            var childObjects = new Dictionary<string, TreeViewItem>();
            
            foreach (var child in currentObject.GetChildren())
            {
                var type = child.ObjectType.Name;
                var typeContainerHeader = GetContainerHeader(type);

                if (!childObjects.ContainsKey(typeContainerHeader))
                {
                    var item = AddTreeItem(typeContainerHeader, currentObjectTreeViewItem);
                    childObjects.Add(typeContainerHeader, item);
                }
                    
                var childTreeViewItem = AddTreeItem(child.Name.ToString(), childObjects[typeContainerHeader]);

                DisplayObject(child, childTreeViewItem);
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
            var panel = new StackPanel {Orientation = Orientation.Vertical};
            panel.Margin = new Thickness(100, 25, 0, 0);
            

            var nameLabel = new Label();
            nameLabel.Content = item.Name;
            nameLabel.Margin = new Thickness(0, 5, 0, 25);
            nameLabel.FontSize = 16.0;

            panel.Children.Add(nameLabel);

            foreach (var property in item.ObjectType.Properties)
            {
                var val = property.GetValue<object>(item);
                if (val == null)
                {
                    val = "NULL";
                }

                var displayText = string.Format("{0} = {1}", property.Name, val);

                var label = new Label();
                label.Content = displayText;

                panel.Children.Add(label);
            }

            return panel;
        }

        private TreeViewItem AddRootTreeItem(string header)
        {
            return AddTreeItem(header, TreeView);

        }

        private TreeViewItem AddTreeItem(string header, ItemsControl parent)
        {
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

}
