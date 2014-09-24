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

            DisplayTables();
            AddRootTreeItem("Procedures");
            AddRootTreeItem("Security");

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

            var display = item.Tag as CachedDisplay;

            if (null == display)
                return;

            Properties.Children.Add(display.Properties);
            ScriptDisplay.Text = display.Script;

        }

        private void DisplayTables()
        {
            var rootNode = AddRootTreeItem("Tables");
            
            var tables = _model.GetObjects(DacQueryScopes.All, ModelSchema.Table);

            foreach (var table in tables)
            {
                var tableNode = AddTreeItem(table.Name.ToString(), rootNode);
                DisplayTableNode(table, tableNode);
            }

        }

        private void DisplayTableNode(TSqlObject table, TreeViewItem tableNode)
        {
            
            var properties = GetPropertiesDisplay(table);
            var script = GetScript(table);

            tableNode.Tag = new CachedDisplay()
            {
                Properties = properties,
                Script = script
            };

            //var columnsNode = AddTreeItem("Columns", tableNode);
            var childObjects = new Dictionary<string, TreeViewItem>();
            

            foreach (var column in table.GetChildren())
            {
                var type = column.ObjectType.Name;
                var typeContainerHeader = string.Format("{0}s", type);
                if (!childObjects.ContainsKey(type))
                {
                    var item = AddTreeItem(typeContainerHeader, tableNode);
                }


            }

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

    public class CachedDisplay
    {
        public string Script { get; set; }
        public UIElement Properties { get; set; }
    }

}
