using System;

namespace DacpacExplorer
{
    public class ModelParsingException : Exception
    {
        public ModelParsingException(string format, params object[] args) : base(string.Format(format, args))
        {
            
        }
    }
}