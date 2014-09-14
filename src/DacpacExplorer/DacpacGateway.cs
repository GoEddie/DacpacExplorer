using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dacpac;

namespace DacpacExplorer
{
    class DacpacGateway
    {
        public DataSchemaModel GetDataSchemaModel(string path)
        {
            using (var package = Package.Open(path, FileMode.Open, FileAccess.Read))
            {
                foreach (var part in package.GetParts())
                {
                    if (part.ContentType == "text/xml")
                    {
                        if (part.Uri.ToString() == "/model.xml")
                        {
                            return ModelFile.GetModelFile(part.GetStream());
                        }
                    }
                    
                }
            }

            throw new FileNotFoundException("model.xml not foundin the dacpac - boo hoo hoo :(");
        }
    }
}
