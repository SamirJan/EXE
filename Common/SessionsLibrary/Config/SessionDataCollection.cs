using System;
using System.Configuration;
using System.Linq;

namespace SessionsLibrary
{
    [ConfigurationCollection(typeof(SessionDataElement), AddItemName = "sessionData")]
    public class SessionDataCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement() => new SessionDataElement();

        protected override object GetElementKey(ConfigurationElement element) => ((SessionDataElement)element).Name;
    }
}
