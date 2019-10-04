using DevExpress.Xpo.DB;
using System;
using System.Configuration;
using System.Linq;

namespace SessionsLibrary
{
    public class SessionDataElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get => (string)this["name"];
            set => this["name"] = value;
        }

        [ConfigurationProperty("serverName", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string ServerName
        {
            get => (string)this["serverName"];
            set => this["serverName"] = value;
        }

        [ConfigurationProperty("dbName", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string DBName
        {
            get => (string)this["dbName"];
            set => this["dbName"] = value;
        }
        [ConfigurationProperty("autoCreateOption", DefaultValue = "None", IsKey = false, IsRequired = false)]
        public AutoCreateOption AutoCreateOption
        {
            get => (AutoCreateOption)this["autoCreateOption"];
            set => this["autoCreateOption"] = value;
        }

        [ConfigurationProperty("threadSafe", DefaultValue = false, IsKey = false, IsRequired = false)]
        public bool ThreadSafe
        {
            get => (bool)this["threadSafe"];
            set => this["threadSafe"] = value;
        }

        [ConfigurationProperty(nameof(TypeLibs), IsDefaultCollection = true)]
        public TypeLibCollection TypeLibs => ((TypeLibCollection)(base[nameof(TypeLibs)]));
    }
}
