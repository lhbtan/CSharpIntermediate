using System.Collections.Generic;

namespace CSharpIntermediateLloyd
{
    public class DataObjectMapper
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}