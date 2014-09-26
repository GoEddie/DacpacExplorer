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
        private bool _validateModel;

        public static ModelRepository GetRepository()
        {
            return Singleton;
        }

        private ModelRepository()
        {
            
        }

        public bool ValidateModel()
        {
            return _validateModel;
        }

        public void SetModel(TSqlModel model, bool validateModel)
        {
            _validateModel = validateModel;
            _model = model;
        }

        public TSqlModel GetModel()
        {
            return _model;
        }

    }
}
