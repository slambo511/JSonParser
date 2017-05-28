using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace JSonParser
{
    public class Settings
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        public Settings()
        {
            var contacts = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(@"G:\Test\JOSN\Settings.json");

            Debug.WriteLine(contacts[1]["name"]);
        }

        public void Set(string key, string value)
        {
            if (_settings.ContainsKey(key))
            {
                _settings[key] = value;
            }
            else
            {
                _settings.Add(key, value);
            }
        }

        public string Get(string key)
        {
            string result = null;

            if (_settings.ContainsKey(key))
            {
                result = _settings[key];
            }

            return result;
        }

    }
}
