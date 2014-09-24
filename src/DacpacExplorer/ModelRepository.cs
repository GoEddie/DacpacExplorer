using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer
{
    class ModelRepository
    {
        private static readonly ModelRepository Singleton = new ModelRepository();
        private TSqlModel _model;

        public static ModelRepository GetRepository()
        {
            return Singleton;
        }

        private ModelRepository()
        {
            
        }

        public void SetModel(TSqlModel model)
        {
            _model = model;
        }

        public TSqlModel GetModel()
        {
            return _model;
        }

    }
}
