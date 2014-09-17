using System;
using System.Collections.Generic;
using System.Linq;
using DacpacExplorer.Redefinitions;
using Microsoft.Isam.Esent.Interop;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer
{
    public static class TsqlObjectExtensions
    {
        public static TableDefinition GetTableDefinition(this TSqlObject source)
        {
            var tableDefinition = new TableDefinition(source);
            

            foreach (var child in source.GetChildren())
            {
                Console.WriteLine(child.Name + " : " + child.ObjectType.Name);

                switch (EnumHelper<SqlObjectTypes>.ToEnum(child.ObjectType.Name))
                {
                        //    var expression = child.GetProperty<string>(DefaultConstraint.Expression);
                        
                    case SqlObjectTypes.Column:
                        tableDefinition.Columns.Add( child.GetColumnDefinition(tableDefinition) );
                        break;
                    case SqlObjectTypes.Table:
                        throw new ModelParsingException("A Table cannot be a child of a Table");
                        
                    case SqlObjectTypes.DataType:
                        throw new ModelParsingException("A Table does not have a DataType");
                        
                    case SqlObjectTypes.DefaultConstraint:
                        child.GetDefaultConstraint(tableDefinition);

                        //do SOMETHING HERE WITH THIS - plus create link  between column and constraint
                        break;
                    
                }
            }

            return tableDefinition;
        }

        public static List<ColumnDefinition> GetColumnDefinitions(this TSqlObject source, TableDefinition tableDefinition)
        {
            if (source.ObjectType.Name != "Table")
            {
                throw new NotSupportedException(string.Format("GetCOlumnDefinition only works with a TSqlObject that has an object type of \"Table\" this object type = \"{0}\"'", source.ObjectType.Name));
            }

            var definitions = new List<ColumnDefinition>();

            foreach (var column in source.GetReferenced(Table.Columns))
            {
                definitions.Add(GetColumnDefinition(column, tableDefinition));
            }

            return definitions;
        }

        public static DefaultConstraintDefinition GetDefaultConstraint(this TSqlObject source, TableDefinition tableDefinition )
        {
            
            if (!source.IsOfType(SqlObjectTypes.DefaultConstraint))
            {
                throw new ModelParsingException("Expected DefaultConstraint but got: {0}", source.ObjectType.Name);
            }

            var definition = new DefaultConstraintDefinition(source)
            {
                Expression = source.GetProperty<object>(DefaultConstraint.Expression) as string /*for some reason I can't use GetProperty<string> but getting an object and casting works - odd!*/
                ,Disabled = source.GetProperty<bool>(DefaultConstraint.Disabled)
                // ,TargetColumn = GetColumnDefinition()
            };

            var targetColumn = source.GetReferenced(DefaultConstraint.TargetColumn).FirstOrDefault();

            definition.ParentColumn =
                tableDefinition.Columns.FirstOrDefault(p => p.GetName() == targetColumn.Name.ToString());

            return definition;
        }

        public static ColumnDefinition GetColumnDefinition(this TSqlObject source, TableDefinition table)
        {
            if (source.ObjectType.Name != "Column")
            {
                throw new NotSupportedException(string.Format("GetColumnDefinition only works with a TSqlObject that has an object type of \"Column\" this object type = \"{0}\"'", source.ObjectType.Name));
            }

            var definiton = new ColumnDefinition(source, table);

            var typeName = source.GetReferenced().FirstOrDefault();

            if (!typeName.IsOfType(SqlObjectTypes.DataType))
            {
                throw new ModelParsingException("Expected DataType but got: {0}", typeName.ObjectType.Name);
            }

            definiton.SqlType = typeName.Name.ToString();

            foreach (var p in source.ObjectType.Properties)
            {
                // Console.WriteLine("{0} : {1}", p.Name, p.GetValue<object>(source));
                if ( p.OwningRelationship != null)
                {
                    switch (EnumHelper<ColumnPropertyName>.ToEnum(p.Name))
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
                           //This isn't a property on the column, it is a child of the teable

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

       


        public static bool IsOfType(this TSqlObject source, SqlObjectTypes type)
        {
            if (source.ObjectType == null)
            {
                throw new ModelParsingException("TSqlObject has no ObjectType");
            }

            return (source.ObjectType.Name == type.ToString());
        }
    }
}