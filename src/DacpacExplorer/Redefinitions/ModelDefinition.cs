using System.Collections.Generic;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public class ModelDefinition : ContainerDefinition
    {
        public readonly TSqlModel WeaklyTypedModel;
        public List<TableDefinition> Tables = new List<TableDefinition>(); 
        public List<ColumnDefinition> Columns = new List<ColumnDefinition>();
        public List<IndexDefinition> Indexes = new List<IndexDefinition>();
        public List<PrimaryKeyDefinition> PrimaryKeys = new List<PrimaryKeyDefinition>();
        public List<DefaultConstraintDefinition> Defaults = new List<DefaultConstraintDefinition>();
        public List<ForeignKeyConstraintDefinition> ForeignKeys = new List<ForeignKeyConstraintDefinition>(); 


        public ModelDefinition(TSqlModel weaklyTypedModel)
        {
            WeaklyTypedModel = weaklyTypedModel;
            Name = "Model";
            foreach (var table in WeaklyTypedModel.GetObjects(DacQueryScopes.Default, Table.TypeClass))
            {
                var tableDef = table.GetTableDefinition(this);

                Columns.AddRange(tableDef.Columns);
                PrimaryKeys.Add(tableDef.PrimaryKey);
                Defaults.AddRange(tableDef.Defaults);
                Tables.Add(tableDef);
            }
        }

        
        public string Name { get; private set; }
    }
}