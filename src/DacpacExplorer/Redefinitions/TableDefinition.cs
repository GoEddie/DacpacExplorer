using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public class TableDefinition : SqlObjectRedefinition, ContainerDefinition
    {
        public List<ColumnDefinition> Columns = new List<ColumnDefinition>();
        public List<DefaultConstraintDefinition> Defaults = new List<DefaultConstraintDefinition>();
        public List<ForeignKeyConstraintDefinition> ForeignKeys = new List<ForeignKeyConstraintDefinition>(); 
        public List<DmlTriggerDefinition> DmlTriggers = new List<DmlTriggerDefinition>();
        public List<IndexDefinition> Indexes = new List<IndexDefinition>();
 
        public PrimaryKeyDefinition PrimaryKey;

        public TableDefinition(TSqlObject weakObject, ModelDefinition model) : base(weakObject, model)
        {
            Name = weakObject.Name.ToString();

            foreach (var child in weakObject.GetChildren())
            {
               // Console.WriteLine(child.Name + " : " + child.ObjectType.Name);

                switch (EnumHelper<SqlObjectTypes>.ToEnum(child.ObjectType.Name))
                {
                        //    var expression = child.GetProperty<string>(DefaultConstraint.Expression);

                    case SqlObjectTypes.Column:
                        Columns.Add(child.GetColumnDefinition(this));
                        break;
                    case SqlObjectTypes.Table:
                        throw new ModelParsingException("A Table cannot be a child of a Table");

                    case SqlObjectTypes.DataType:
                        throw new ModelParsingException("A Table does not have a DataType");

                    case SqlObjectTypes.DefaultConstraint:
                        Defaults.Add(child.GetDefaultConstraint(this));
                        break;
                    case SqlObjectTypes.PrimaryKeyConstraint:
                        PrimaryKey = new PrimaryKeyDefinition(child, this);
                        break;

                    case SqlObjectTypes.ForeignKeyConstraint:
                        ForeignKeys.AddRange(child.GetForeignKeyDefinitions(this));
                        break;
                    case SqlObjectTypes.DmlTrigger:
                        DmlTriggers.Add(new DmlTriggerDefinition(child, this));
                        break;
                    case SqlObjectTypes.Index:
                        Indexes.Add(new IndexDefinition(child, this));
                        break;
                    default:

                        Console.WriteLine("eeeek");
                        break;

                }
            }

        }

        public string Name { get; private set; }
    }
}