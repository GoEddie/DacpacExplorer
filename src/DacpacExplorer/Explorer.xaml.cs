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

        public Explorer()
        {
            InitializeComponent();

            var app = Application.Current.Properties["App"] as App;
            
            app.ModelUpdated += parent_ModelUpdated;

            SetFileDisplay();
            parent_ModelUpdated(this);
        }

        private void SetFileDisplay()
        {
            var app = Application.Current.Properties["App"] as App;
            
            if (!File.Exists(app.DacFilePath))
            {
                DisplayFilePath.Text = "Please choose a valid dacpac file";
                return;
            }

            DisplayFilePath.Text = app.DacFilePath;
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

            root.Items.Add(new TreeViewItem() {Header = string.Format("Version : {0}", DisplayVersion())});
//            ShowRootProperties(root);
  //          ShowModelHeader(root);
           ShowModel(root);

            TreeView.Items.Add(root);

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
            var tablesNode = new TreeViewItem() { Header = "Tables" };

            var modelDefinition = _model.GetModelDefinition();

            foreach (var table in modelDefinition.Tables)
            {
                ShowTable(table, tablesNode);
            }

            tablesNode.ExpandSubtree();

            root.Items.Add(tablesNode);
        }

        private void ShowTable(TableDefinition table, TreeViewItem tablesNode)
        {
            var treeNode = new TreeViewItem();
            treeNode.Header = table.Name;

            var columnsNode = new TreeViewItem();
            columnsNode.Header = "Columns";

            treeNode.Items.Add(columnsNode);

            foreach (var columnDefinition in table.Columns)
            {
                ShowColumn(columnDefinition, columnsNode);
            }

            tablesNode.Items.Add(treeNode);

        }

        private void ShowColumn(ColumnDefinition columnDefinition, TreeViewItem columnsNode)
        {
            var columnNode = new TreeViewItem();
            columnNode.Header = columnDefinition.GetName();

            columnsNode.Items.Add(columnNode);
        }

        
    }
}
