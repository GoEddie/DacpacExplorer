using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public class SqlObjectRedefinition
    {
        public TSqlObject WeaklyTypedObject;

        public SqlObjectRedefinition(TSqlObject weaklyTypedObject)
        {
            WeaklyTypedObject = weaklyTypedObject;
        }

        public string GetName()
        {
            return WeaklyTypedObject.Name.ToString();
        }

        public SqlObjectTypes GetUnderlyingType()
        {
            return EnumHelper<SqlObjectTypes>.ToEnum(WeaklyTypedObject.ObjectType.Name);
        }
    }

    public class DefaultConstraintDefinition : SqlObjectRedefinition
    {
        public DefaultConstraintDefinition(TSqlObject weakObject) : base(weakObject)
        {
            
        }

        public string Expression;

        public bool Disabled;
        
        //public static ModelPropertyClass WithValues { get; internal set; }
        
        //public static ModelRelationshipClass Host { get; internal set; }

        public ColumnDefinition ParentColumn;
        
        //public static ModelRelationshipClass ExpressionDependencies { get; internal set; }
        
    }

    public class TableDefinition : SqlObjectRedefinition
    {
        public List<ColumnDefinition> Columns = new List<ColumnDefinition>();

        public TableDefinition(TSqlObject weakObject)
            : base(weakObject)
        {
            
        }

    }

    public class ColumnDefinition : SqlObjectRedefinition
    {
        public ColumnDefinition(TSqlObject weakObject, TableDefinition parent) : base(weakObject)
        {
            ParentTable = parent;
        }

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

        public TableDefinition ParentTable;
    }

}