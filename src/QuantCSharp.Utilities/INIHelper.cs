using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration.Ini;
namespace QuantCSharp.Utilities
{
    public class INIHelper
    {
        readonly Microsoft.Extensions.Configuration.IConfiguration configuration;
        public INIHelper(string iniPath)
        {
            Microsoft.Extensions.Configuration.ConfigurationBuilder configurationBuilder =
new Microsoft.Extensions.Configuration.ConfigurationBuilder();
            configurationBuilder.AddIniFile(iniPath, false);
            configuration = configurationBuilder.Build();
        }

        public string ReadIniSection(string sectionName)
        {
            return configuration[sectionName];
        }

        public string this[string sectionName]
        {
             get {
                return configuration[sectionName];
            } 
        }

        public bool ReadBoolean(string sectionName)
        {
            var xc = ReadIniSection(sectionName);
            return bool.TrueString.Equals(xc, StringComparison.OrdinalIgnoreCase);
        }

        public int ReadInt32(string sectionName)
        {
            var xc = ReadIniSection(sectionName);
            return int.Parse(xc);
        }

    }
}
