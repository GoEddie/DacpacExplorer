using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                var tableNode = new TreeViewItem() { Header = string.Format("{0}", table.Name) };
                ShowColumns(tableNode, table);

                    //ShowKeys(tableNode, table);
                    //tablesNode.Items.Add(tableNode);
                tablesNode.Items.Add(tableNode);

            }

            root.Items.Add(tablesNode);
        }

        private void ShowColumns(TreeViewItem tableNode, TSqlObject table)
        {
            var columns = table.GetColumnDefinitions();

            
        }
    }
    
  
    
    public static class TsqlObjectExtensions
    {
        public static List<ColumnDefinition> GetColumnDefinitions(this TSqlObject source)
        {
            if (source.ObjectType.Name != "Table")
            {
                throw new NotSupportedException(string.Format("GetCOlumnDefinition only works with a TSqlObject that has an object type of \"Table\" this object type = \"{0}\"'", source.ObjectType.Name));
            }

            var definitions = new List<ColumnDefinition>();

            foreach (var column in source.GetReferenced(Table.Columns))
            {
                definitions.Add(GetColumnDefinition(column));
            }

            return definitions;
        }

        public static ColumnDefinition GetColumnDefinition(this TSqlObject source)
        {
            if (source.ObjectType.Name != "Column")
            {
                throw new NotSupportedException(string.Format("GetColumnDefinition only works with a TSqlObject that has an object type of \"Column\" this object type = \"{0}\"'", source.ObjectType.Name));
            }

            var definiton = new ColumnDefinition();
            var typeName = source.GetReferenced().FirstOrDefault();

            if (!typeName.IsOfType(TSqlObjectTypes.DataType))
            {
                throw new ModelParsingException("Expected DataType but got: {0}", typeName.ObjectType.Name);
            }

            definiton.SqlType = typeName.Name.ToString();

            foreach (var p in source.ObjectType.Properties)
            {
               // Console.WriteLine("{0} : {1}", p.Name, p.GetValue<object>(source));
                if ( p.OwningRelationship != null)
                {
                    switch (ColumnPropertyNameHelper.ToEnum(p.Name))
                    {
                        case ColumnPropertyName.Collation:
                            definiton.Collation = p.GetValue<string>(source);
                            break;
                        case ColumnPropertyName.IsIdentityNotForReplication:
                            definiton.IsIdenityNotForReplication = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.Nullable:
                            definiton.Nullable = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.IsRowGuidCol:
                            definiton.IsRowGuidCol = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.Sparse:
                            definiton.Sparse = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.Expression:
                            //definiton.Expression = 
                            //p.GetValue<Microsoft.Data.Tools.Schema.Sql.SchemaModel.SqlScriptProperty>(source);
                            //this needs to check for null or try catch it! ahhhhhhhhhh!!!!
                            break;
                        case ColumnPropertyName.Persisted:
                            definiton.Persisted = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.PersistedNullable:
                            definiton.PersistedNullable = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.Scale:
                            definiton.Scale = p.GetValue<int>(source);
                            break;
                        case ColumnPropertyName.Precision:
                            definiton.Precision = p.GetValue<int>(source);
                            break;
                        case ColumnPropertyName.Length:
                            definiton.Length = p.GetValue<int>(source);
                            break;
                        case ColumnPropertyName.IsMax:
                            definiton.IsMax = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.XmlStyle:
                            definiton.XmlStyle = p.GetValue<int>(source);
                            break;
                        case ColumnPropertyName.IdentityIncrement:
                            definiton.IdentityIncrement = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.IdentitySeed:
                            definiton.IdentitySeed = p.GetValue<string>(source);
                            break;
                        case ColumnPropertyName.IsFileStream:
                            definiton.IsFileStream = p.GetValue<bool>(source);
                            break;
                        case ColumnPropertyName.IsIdentity:
                            definiton.IsIdentity = p.GetValue<bool>(source);
                            break;
                    }
                }
            }

            return definiton;
        }

        public class ColumnDefinition
        {
            public string SqlType;

            public string Collation;
            public bool IsIdenityNotForReplication;
            public bool IsRowGuidCol;
            public bool Sparse;
            public string Expression;
            public bool Persisted;
            public bool PersistedNullable;
            public int Scale;
            public int Precision;
            public int Length;
            public bool IsMax;
            public int XmlStyle;
            public bool IdentityIncrement;
            public string IdentitySeed;
            public bool IsFileStream;
            public bool IsIdentity;
            public bool Nullable;
        }


        public static bool IsOfType(this TSqlObject source, TSqlObjectTypes type)
        {
            if (source.ObjectType == null)
            {
                throw new ModelParsingException("TSqlObject has no ObjectType");
            }

            return (source.ObjectType.Name == TSqlObjectTypeHelper.FromEnum(type));
        }
    }

    public enum ColumnPropertyName
    {
        Collation,
        IsIdentityNotForReplication,
        Nullable,
        IsRowGuidCol,
        Sparse,
        Expression,
        Persisted,
        PersistedNullable,
        Scale,
        Precision,
        Length,
        IsMax,
        XmlStyle,
        IdentityIncrement,
        IdentitySeed,
        IsFileStream,
        IsIdentity
    }   
    
    public enum TSqlObjectTypes
    {
        Column,
        Table,
        DataType
    }

    public static class ColumnPropertyNameHelper
    {
        public static ColumnPropertyName ToEnum(string name)
        {
            ColumnPropertyName result;

            if (Enum.TryParse(name, true, out result))
                return result;

            throw new ModelParsingException("Unable to convert \"{0}\" to a ColumnPropertyName");
        }

        
    }

    public static class TSqlObjectTypeHelper
    {
        public static TSqlObjectTypes ToEnum(string name)
        {
            switch (name)
            {
                case "Column":
                    return TSqlObjectTypes.Column;
                case "Table":
                    return TSqlObjectTypes.Table;
                case "DataType":
                    return TSqlObjectTypes.DataType;
                default:
                    throw new ArgumentOutOfRangeException(string.Format("name received value: {0}", name));
            }
        }

        public static string FromEnum(TSqlObjectTypes type)
        {
            switch (type)
            {
                case TSqlObjectTypes.Column:
                    return "Column";
                case TSqlObjectTypes.Table:
                    return "Table";
                case TSqlObjectTypes.DataType:
                    return "DataType";
                default:
                    throw new ArgumentOutOfRangeException(string.Format("type received value: {0}", type));
            }
        }
    }

    public class ModelParsingException : Exception
    {
        public ModelParsingException(string format, params object[] args) : base(string.Format(format, args))
        {
            
        }
    }

}
