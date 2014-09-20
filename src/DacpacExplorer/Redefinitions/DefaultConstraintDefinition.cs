using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public class ForeignKeyConstraintDefinition : SqlObjectRedefinition
    {
        
        public ForeignKeyConstraintDefinition(TSqlObject weakObject, TableDefinition tableDefinition) : base(weakObject, tableDefinition)
        {
            
            //Get attributes and once we have all the tables we need to go back and re-initialize theese as we can't be sure we have two tables.
        }

        public void SetReferences(List<TableDefinition> tables)
        {
            //Now 
        }
    }

    public class DmlTriggerDefinition : SqlObjectRedefinition
    {

        public bool AnsiNullsOn;
        public bool Disabled;
        public bool QuotedIdentifierOn;
        public TriggerType TriggerType;

        public DmlTriggerDefinition(TSqlObject weaklyTypedObject, TableDefinition tableDefinition) : base(weaklyTypedObject, tableDefinition)
        {
            AnsiNullsOn = weaklyTypedObject.GetProperty<bool>(DmlTrigger.AnsiNullsOn);
            Disabled = weaklyTypedObject.GetProperty<bool>(DmlTrigger.Disabled);
            QuotedIdentifierOn = weaklyTypedObject.GetProperty<bool>(DmlTrigger.QuotedIdentifierOn);
            TriggerType = weaklyTypedObject.GetProperty<TriggerType>(DmlTrigger.TriggerType);
            
        }
    }
    /*
          public static ModelPropertyClass AnsiNullsOn { get; internal set; }
    public static ModelRelationshipClass Assembly { get; internal set; }
    public static ModelRelationshipClass BodyDependencies { get; internal set; }
    public static ModelPropertyClass ClassName { get; internal set; }
    public static ModelPropertyClass DeleteOrderRestriction { get; internal set; }
    public static ModelPropertyClass Disabled { get; internal set; }
    public static ModelPropertyClass ExecuteAsCaller { get; internal set; }
    public static ModelPropertyClass ExecuteAsOwner { get; internal set; }
    public static ModelPropertyClass ExecuteAsSelf { get; internal set; }
    public static ModelPropertyClass InsertOrderRestriction { get; internal set; }
    public static ModelPropertyClass IsDeleteTrigger { get; internal set; }
    public static ModelPropertyClass IsInsertTrigger { get; internal set; }
    public static ModelPropertyClass IsUpdateTrigger { get; internal set; }
    public static ModelRelationshipClass Login { get; internal set; }
    public static ModelPropertyClass MethodName { get; internal set; }
    public static ModelPropertyClass NotForReplication { get; internal set; }
    public static ModelPropertyClass QuotedIdentifierOn { get; internal set; }
    public static ModelRelationshipClass TriggerObject { get; internal set; }
    public static ModelPropertyClass TriggerType { get; internal set; }
    public static ModelTypeClass TypeClass { get; internal set; }
    public static ModelPropertyClass UpdateOrderRestriction { get; internal set; }
    public static ModelRelationshipClass User { get; internal set; }
    public static ModelPropertyClass WithAppend { get; internal set; }
    public static ModelPropertyClass WithEncryption { get; internal set; }
 
    */
    public class DefaultConstraintDefinition : SqlObjectRedefinition
    {
        public DefaultConstraintDefinition(TSqlObject weakObject, TableDefinition tableDefinition) : base(weakObject, tableDefinition)
        {
            Expression = weakObject.GetProperty<object>(DefaultConstraint.Expression) as string;

            Disabled = weakObject.GetProperty<bool>(DefaultConstraint.Disabled);

            var targetColumn = weakObject.GetReferenced(DefaultConstraint.TargetColumn).FirstOrDefault();

            ParentColumn = tableDefinition.Columns.FirstOrDefault(p => p.GetName() == targetColumn.Name.ToString());
        }

        public string Expression;

        public bool Disabled;
        
        //public static ModelPropertyClass WithValues { get; internal set; }
        
        //public static ModelRelationshipClass Host { get; internal set; }

        public ColumnDefinition ParentColumn;
        
        //public static ModelRelationshipClass ExpressionDependencies { get; internal set; }
        
    }
}