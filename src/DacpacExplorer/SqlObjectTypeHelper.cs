using System;

namespace DacpacExplorer
{
    public static class EnumHelper<T> where T : struct
    {
        public static T ToEnum(string name) 
        {
            T result;

            if (Enum.TryParse(name, true, out result))
                return result;

            return result;
            //throw new ModelParsingException("Unable to convert \"{0}\" to a {1}", name, typeof(T));
        }
        
    }
}