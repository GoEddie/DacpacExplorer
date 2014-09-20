using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using DacpacExplorer.Redefinitions;
using Microsoft.SqlServer.Dac.Model;
using ColumnDefinition = DacpacExplorer.Redefinitions.ColumnDefinition;


namespace DacpacExplorer
{
    public partial class Explorer : Page
    {
        private TSqlModel _model;
        private App _app;

        public Explorer()
        {
            InitializeComponent();

            _app = Application.Current.Properties["App"] as App;
            
            _app.ModelUpdated += parent_ModelUpdated;

            SetFileDisplay();
            parent_ModelUpdated(this);
        }

        private void SetFileDisplay()
        {
           
            if (!File.Exists(_app.DacFilePath))
            {
                DisplayFilePath.Text = "Please choose a valid dacpac file";
                return;
            }

            DisplayFilePath.Text = _app.DacFilePath;
        }

        void parent_ModelUpdated(object sender)
        {
            _model = _app.Model;

            SetFileDisplay();
            ShowTreeview();
        }

        private void ShowTreeview()
        {
            var root = new TreeViewItem();
            root.Header = "Dacpac";

          //  root.Items.Add(new TreeViewItem() {Header = string.Format("Version : {0}", DisplayVersion())});
//            ShowRootProperties(root);
  //          ShowModelHeader(root);
           ShowModel(root);

            TreeView.Items.Add(root);
            TreeView.Focus();
        }

        private string DisplayVersion()
        {
            switch (_model.Version)
            {
                case SqlServerVersion.Sql90:
                    return "Sql Server 2005";
                    
                case SqlServerVersion.Sql100:
                    return "Sql Server 2008";
                case SqlServerVersion.SqlAzure:
                    return "Sql Server Azure Database";
                case SqlServerVersion.Sql110:
                    return "Sql Server 2012";
                case SqlServerVersion.Sql120:
                    return "Sql Server 2014";
            }

            return "Unknown: " + _model.Version;
        }

        private void ShowModel(TreeViewItem root)
        {
            root.Items.Clear();
            ShowTables(root);
        }

        private void ShowTables(TreeViewItem root)
        {
            var tablesNode = new TreeViewItem() { Header = "Tables"};

            if (_model == null)
                return;

            var modelDefinition = _model.GetModelDefinition();

            foreach (var table in modelDefinition.Tables)
            {
                ShowTable(table, tablesNode);
            }

            

            root.Items.Add(tablesNode);
        }

        private void ShowTable(TableDefinition table, TreeViewItem tablesNode)
        {
            var treeNode = new TreeViewItem();
            treeNode.Header = table.Name;
            treeNode.Tag = table;

            var columnsNode = new TreeViewItem();
            columnsNode.Header = "Columns";

            treeNode.Items.Add(columnsNode);

            foreach (var columnDefinition in table.Columns)
            {
                AddLeafNode(columnDefinition, columnsNode);
            }

            var indexesNode = new TreeViewItem();
            indexesNode.Header = "Indexes";

            foreach (var indexDefinition in table.Indexes)
            {
                AddLeafNode(indexDefinition, indexesNode);
            }

            treeNode.Items.Add(indexesNode);
            

            var defaultsNode = new TreeViewItem();
            defaultsNode.Header = "Defaults";
            foreach (var def in table.Defaults)
            {
                AddLeafNode(def, defaultsNode);
            }


            treeNode.Items.Add(defaultsNode);


            tablesNode.Items.Add(treeNode);

        }

        
        private void AddLeafNode(SqlObjectRedefinition itemDefinition, TreeViewItem columnsNode)
        {
            var leafNode = new TreeViewItem();
            leafNode.Header = itemDefinition.GetName();
            leafNode.Tag = itemDefinition;
            columnsNode.Items.Add(leafNode);
            
        }

        private void SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var newItem = e.NewValue as TreeViewItem;
            if (null == newItem || newItem.Tag == null)
                return;

            var objectDefinition = newItem.Tag as SqlObjectRedefinition;
            if (null == objectDefinition)
                return;

            _app.SelectedObject = objectDefinition;
            _app.InvokeSelectedObjectChanged(objectDefinition);
        }
    }
}
