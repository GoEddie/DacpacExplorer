using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using dacpac;


namespace DacpacExplorer
{
    public class ModelFile
    {
        public static DataSchemaModel GetModelFile(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(DataSchemaModel));
            return serializer.Deserialize(stream) as DataSchemaModel;        
        }
    }
}
