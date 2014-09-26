using System.Collections.Generic;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Pages
{
    public class SqlObjectComparer : IComparer<TSqlObject>
    {
        public int Compare(TSqlObject x, TSqlObject y)
        {
            return x.Name.ToString().CompareTo(y.Name.ToString());
        }
    }
}