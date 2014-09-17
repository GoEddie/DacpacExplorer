using System.Linq;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public class ColumnDefinition : SqlObjectRedefinition
    {
        public ColumnDefinition(TSqlObject weakObject, TableDefinition parent) : base(weakObject, parent)
        {
            var typeName = weakObject.GetReferenced().FirstOrDefault();

            if (!typeName.IsOfType(SqlObjectTypes.DataType))
            {
                throw new ModelParsingException("Expected DataType but got: {0}", typeName.ObjectType.Name);
            }

            SqlType = typeName.Name.ToString();

            foreach (var p in weakObject.ObjectType.Properties)
            {
                // Console.WriteLine("{0} : {1}", p.Name, p.GetValue<object>(weakObject));
                if (p.OwningRelationship != null)
                {
                    switch (EnumHelper<ColumnPropertyName>.ToEnum(p.Name))
                    {
                        case ColumnPropertyName.Collation:
                            Collation = p.GetValue<string>(weakObject);
                            break;
                        case ColumnPropertyName.IsIdentityNotForReplication:
                            IsIdenityNotForReplication = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.Nullable:
                            Nullable = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.IsRowGuidCol:
                            IsRowGuidCol = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.Sparse:
                            Sparse = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.Expression:
                            //This isn't a property on the column, it is a child of the teable

                            break;
                        case ColumnPropertyName.Persisted:
                            Persisted = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.PersistedNullable:
                            PersistedNullable = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.Scale:
                            Scale = p.GetValue<int>(weakObject);
                            break;
                        case ColumnPropertyName.Precision:
                            Precision = p.GetValue<int>(weakObject);
                            break;
                        case ColumnPropertyName.Length:
                            Length = p.GetValue<int>(weakObject);
                            break;
                        case ColumnPropertyName.IsMax:
                            IsMax = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.XmlStyle:
                            XmlStyle = p.GetValue<int>(weakObject);
                            break;
                        case ColumnPropertyName.IdentityIncrement:
                            IdentityIncrement = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.IdentitySeed:
                            IdentitySeed = p.GetValue<string>(weakObject);
                            break;
                        case ColumnPropertyName.IsFileStream:
                            IsFileStream = p.GetValue<bool>(weakObject);
                            break;
                        case ColumnPropertyName.IsIdentity:
                            IsIdentity = p.GetValue<bool>(weakObject);
                            break;
                    }
                }
            }

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

       }
}