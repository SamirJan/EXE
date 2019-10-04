using System;
using System.Configuration;
using System.Linq;

namespace SessionsLibrary
{
    [ConfigurationCollection(typeof(TypeLibElement), AddItemName = "typeLib")]
    public class TypeLibCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new TypeLibElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((TypeLibElement)element).Name;
        }
    }
}
