using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer
{
    internal class ModelRepository
    {
        private static readonly ModelRepository Singleton = new ModelRepository();
        private bool _LoadScriptDom;
        private TSqlModel _model;
        private bool _validateModel;

        private ModelRepository()
        {
        }

        public static ModelRepository GetRepository()
        {
            return Singleton;
        }

        public bool ValidateModel()
        {
            return _validateModel;
        }

        public bool LoadScriptDom()
        {
            return _LoadScriptDom;
        }

        public void SetModel(TSqlModel model, bool validateModel, bool loadScriptDom)
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