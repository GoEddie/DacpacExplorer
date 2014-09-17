using System.Security.Cryptography.X509Certificates;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Redefinitions
{
    public interface ContainerDefinition
    {
        string Name { get; }
    }

    public class SqlObjectRedefinition
    {
        public TSqlObject WeaklyTypedObject;

        public SqlObjectRedefinition(TSqlObject weaklyTypedObject, ContainerDefinition container)
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

        public string GetScript()
        {
            var script = "";
            if (WeaklyTypedObject.TryGetScript(out script))
                return script;

            return "/ *Object does not contain script or can't be scripted i.e. individual column etc */";
        }
    }
}