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

        public static ModelDefinition GetModelDefinition(this TSqlModel model)
        {
            return new ModelDefinition(model);
        }

        public static TableDefinition GetTableDefinition(this TSqlObject source, ModelDefinition modelDefinition)
        {
            var tableDefinition = new TableDefinition(source, modelDefinition);
            

            return tableDefinition;
        }

        

        public static List<ForeignKeyConstraintDefinition> GetForeignKeyDefinitions(this TSqlObject source, TableDefinition tableDefinition)
        {
            if (!source.IsOfType(SqlObjectTypes.ForeignKeyConstraint))
            {
                throw new NotSupportedException(string.Format("GetCOlumnDefinition only works with a TSqlObject that has an object type of \"ForeignKeyConstraint\" this object type = \"{0}\"'", source.ObjectType.Name));
            }

            var definitions = new List<ForeignKeyConstraintDefinition>();
            return definitions;
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

        //public static PrimaryKeyDefinition GetDefaultConstraint(this TSqlObject source, TableDefinition tableDefinition)
        //{
            
        //}

        public static DefaultConstraintDefinition GetDefaultConstraint(this TSqlObject source, TableDefinition tableDefinition )
        {
            
            if (!source.IsOfType(SqlObjectTypes.DefaultConstraint))
            {
                throw new ModelParsingException("Expected DefaultConstraint but got: {0}", source.ObjectType.Name);
            }
            
            return new DefaultConstraintDefinition(source, tableDefinition);
        }

        public static ColumnDefinition GetColumnDefinition(this TSqlObject source, TableDefinition table)
        {
            if (source.ObjectType.Name != "Column")
            {
                throw new NotSupportedException(string.Format("GetColumnDefinition only works with a TSqlObject that has an object type of \"Column\" this object type = \"{0}\"'", source.ObjectType.Name));
            }

            var definiton = new ColumnDefinition(source, table);

            
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