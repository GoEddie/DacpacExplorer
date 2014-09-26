using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;

namespace ObjectEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = new TSqlModel(@"c:\users\ed\desktop\AdventureWorks2012.dacpac");
            var tables = tmp.GetObjects(DacQueryScopes.All, ModelSchema.Table);
            foreach (var table in tables)
            {
                Console.WriteLine(table.Name);
                Console.WriteLine(table.ObjectType.Name);

                DumpScript(table);

                foreach ( var child in table.GetChildren())
                {
                    Console.WriteLine(child.Name);
                    Console.WriteLine(child.ObjectType.Name);

                    DumpChildren(child, 1);
                }
                
            }
        }

      static  void DumpChildren(TSqlObject parent, int depth)
      {
          DumpScript(parent);
          foreach (var property in parent.ObjectType.Properties)
          {
              DumpProperty(property, parent);
          }

          foreach (var child in parent.GetChildren())
            {
                DumpChildren(child, depth + 1);
            }
      }

        private static void DumpProperty(ModelPropertyClass property, TSqlObject instance)
        {
            Console.WriteLine(property.Name);
            Console.WriteLine(property.GetValue<object>(instance));
        }

        private static void DumpScript(TSqlObject parent)
        {
            var script = "";
            if (parent.TryGetScript(out script))
            {
                Console.WriteLine(script);
            }
        }
    }
}
