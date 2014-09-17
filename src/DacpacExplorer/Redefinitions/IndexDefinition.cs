using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public class IndexDefinition : SqlObjectRedefinition
    {
        public IndexDefinition(TSqlObject weakObject, TableDefinition tableDefinition) : base(weakObject, tableDefinition)
        {
            Disabled = weakObject.GetProperty<bool>(Index.Disabled);
            AllowPageLocks = weakObject.GetProperty<bool>(Index.AllowPageLocks);
            AllowRowLocks = weakObject.GetProperty<bool>(Index.AllowRowLocks);
            Clustered = weakObject.GetProperty<bool>(Index.Clustered);
            FillFactor = weakObject.GetProperty<int?>(Index.FillFactor);
            IgnoreDuplicateKey = weakObject.GetProperty<bool>(Index.IgnoreDuplicateKey);
            RecomputeStatistics = weakObject.GetProperty<bool>(Index.RecomputeStatistics);
            WithPadIndex = weakObject.GetProperty<bool>(Index.WithPadIndex);
            
            var targetColumn = weakObject.GetReferenced(Index.Columns).FirstOrDefault();
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