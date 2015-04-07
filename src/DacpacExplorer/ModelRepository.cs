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
        private bool _LoadScriptDom;

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
        public bool LoadScriptDom()
        {
            return _LoadScriptDom;
        }
        public void SetModel(TSqlModel model, bool validateModel,bool loadScriptDom)
        {
            _validateModel = validateModel;
            _model = model;
            _LoadScriptDom = loadScriptDom;
        }

        public TSqlModel GetModel()
        {
            return _model;
        }

    }
}
