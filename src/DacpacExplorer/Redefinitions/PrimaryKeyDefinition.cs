using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{

    public class PrimaryKeyDefinition : SqlObjectRedefinition
    {
        public PrimaryKeyDefinition(TSqlObject weakObject, TableDefinition tableDefinition) : base(weakObject, tableDefinition)
        {
            /*The property classes are different and not inheritable from index to prmiary key so although they are the same, the property classes are different - aaagghhhhhh*/
            Disabled = weakObject.GetProperty<bool>(PrimaryKeyConstraint.Disabled);
            AllowPageLocks = weakObject.GetProperty<bool>(PrimaryKeyConstraint.AllowPageLocks);
            AllowRowLocks = weakObject.GetProperty<bool>(PrimaryKeyConstraint.AllowRowLocks);
            Clustered = weakObject.GetProperty<bool>(PrimaryKeyConstraint.Clustered);
            FillFactor = weakObject.GetProperty<int?>(PrimaryKeyConstraint.FillFactor);
            IgnoreDuplicateKey = weakObject.GetProperty<bool>(PrimaryKeyConstraint.IgnoreDuplicateKey);
            RecomputeStatistics = weakObject.GetProperty<bool>(PrimaryKeyConstraint.RecomputeStatistics);
            WithPadIndex = weakObject.GetProperty<bool>(PrimaryKeyConstraint.WithPadIndex);
            
            var targetColumn = weakObject.GetReferenced(PrimaryKeyConstraint.Columns).FirstOrDefault();
            Columns.AddRange(tableDefinition.Columns.Where(p => p.GetName() == targetColumn.Name.ToString()));
          
        }

        public bool AllowRowLocks;
        public bool AllowPageLocks;
        public bool Clustered;
        public bool Disabled;
        public int? FillFactor;
        public bool IgnoreDuplicateKey;
        public bool RecomputeStatistics;
        public bool WithPadIndex;
        public List<ColumnDefinition> Columns = new List<ColumnDefinition>();
    }
}