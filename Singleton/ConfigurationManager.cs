using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigurationManager
    {
        private readonly Dictionary<string, object> _configurations = new ();
        private static readonly ConfigurationManager Instance = new ();

        private ConfigurationManager()
        {
                
        }

        public static ConfigurationManager GetConfiguration()
        {
            return Instance;
        }

        public void AddConfig(string key, object value)
        {
            _configurations.Add(key, value);
        }

        public object GetConfig(string key)
        {
            return _configurations[key];
        }
    }
}
