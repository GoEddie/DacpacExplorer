using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.SqlServer.Dac.Model;


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
            ShowTables(root);
        }

        private void ShowTables(TreeViewItem root)
        {
            var tablesNode = new TreeViewItem() { Header = "Tables" };

            foreach (var table in _model.GetObjects(DacQueryScopes.Default, Table.TypeClass))
            {
                var tableDefinition = table.GetTableDefinition();
                Console.WriteLine(tableDefinition.ToString());
            }

            //foreach (var table in _model.GetObjects(DacQueryScopes.Default, Table.TypeClass))
            //{
            //    var tableNode = new TreeViewItem() { Header = string.Format("{0}", table.Name) };
            //    foreach(var child in table.GetChildren())
            //    {
            //        Console.WriteLine(child.Name + " : " + child.ObjectType.Name);

            //        switch (child.ObjectType.Name)
            //        {
            //            case "DefaultConstraint":

            //                var expression = child.GetProperty<string>(DefaultConstraint.Expression);

            //                break;
            //        }
            //    }
                
            //    ShowColumns(tableNode, table);

            //        //ShowKeys(tableNode, table);
            //        //tablesNode.Items.Add(tableNode);
            //    tablesNode.Items.Add(tableNode);

            //}

            root.Items.Add(tablesNode);
        }

        private void ShowColumns(TreeViewItem tableNode, TSqlObject table)
        {
            //var columns = table.GetColumnDefinitions();

            
        }
    }
}
