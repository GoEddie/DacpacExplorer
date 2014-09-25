using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer
{
    class RecursionGuard
    {
        public Dictionary<string, Dictionary<string, TSqlObject>> SeemItems = new Dictionary<string, Dictionary<string, TSqlObject>>();

        public bool Add(string root, string name, TSqlObject item)
        {
            if (!SeemItems.ContainsKey(root))
            {
                SeemItems[root] = new Dictionary<string, TSqlObject>();
            }

            if (SeemItems[root].ContainsKey(name))
                return false;

            SeemItems[root][name] = item;
            return true;
        }

    }
}
