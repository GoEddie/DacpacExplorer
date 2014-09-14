using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using dacpac;


namespace DacpacExplorer
{
    public partial class Explorer : Page
    {
        private DataSchemaModel _model;

        public Explorer()
        {
            InitializeComponent();

            var app = Application.Current.Properties["App"] as App;
            
            app.ModelUpdated += parent_ModelUpdated;

            SetFileDisplay();
        }

        private void SetFileDisplay()
        {
            var app = Application.Current.Properties["App"] as App;
            
            if (!File.Exists(app.DacFilePath))
            {
                DisplayFilePath.Text = "Please choose a valid dacpac file";
                return;
            }
        }

        void parent_ModelUpdated(object sender)
        {
            if ((Application.Current.Properties["App"] as App).Model == null)
                return;

            _model = (Application.Current.Properties["App"] as App).Model;

            SetFileDisplay();
            ShowTreeview();
        }

        private void ShowTreeview()
        {

            var root = new TreeViewItem();
            root.Header = "Dacpac";

            ShowRootProperties(root);
            ShowModelHeader(root);
            ShowModel(root);

            TreeView.Items.Add(root);

        }

        private void ShowModel(TreeViewItem root)
        {
            ShowTables(root);
        }

        private void ShowTables(TreeViewItem root)
        {
            var tablesNode = new TreeViewItem() { Header = "Tables" };
            
            foreach (var item in _model.Model)
            {
                var table = item as ElementType;
                if (table != null && table.Type == "SqlTable")
                {
                    var tableNode = new TreeViewItem() {Header = string.Format("{0}", table.Name)};
                    ShowColumns(tableNode, table);

                    tablesNode.Items.Add(tableNode);
                }
            }

            root.Items.Add(tablesNode);
        }

        private void ShowColumns(TreeViewItem tableNode, ElementType table)
        {
            foreach (var item in table.Items)
            {
                var columns = item as RelationshipType;
                if (columns != null && columns.Name == "Columns")
                {
                    foreach (var subItem in columns.Entry)
                    {
                        var column = subItem as ElementType;
                        tableNode.Items.Add(new TreeViewItem(){Header = columns.Name});
                    }
                }
                
            }
        }


        private bool IsHandledProperty(string propertyName)
        {
            return propertyName == "Model" || propertyName == "Header";
        }

        private void ShowRootProperties(TreeViewItem root)
        {
            var item = new TreeViewItem() {Header = "Properties"};

            foreach (var prop in _model.GetType().GetProperties())
            {
                if (!IsHandledProperty(prop.Name))
                {
                    item.Items.Add(new TreeViewItem()
                    {
                        Header = string.Format("{0} - {1}", prop.Name, prop.GetValue(_model))
                    });
                }

            }

            root.Items.Add(item);
        }

        private void ShowModelHeader(TreeViewItem root)
        {
            foreach (var header in _model.Header)
            {
                var headerTreeItem = new TreeViewItem();
                headerTreeItem.Header = header.Category;

                foreach (var item in header.Metadata)
                {
                    headerTreeItem.Items.Add(new TreeViewItem()
                    {
                        Header = string.Format("{0} - {1}", item.Name, item.Value)
                    });
                }

                root.Items.Add(headerTreeItem);
            }
        }
    }
}
