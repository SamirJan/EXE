using System;
using System.Configuration;
using System.Linq;

namespace SessionsLibrary
{
    public class TypeLibElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get => (string)this["name"];
            set => this["name"] = value;
        }

        [ConfigurationProperty("assemblyName", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string AssemblyName
        {
            get => (string)this["assemblyName"];
            set => this["assemblyName"] = value;
        }
    }
}
