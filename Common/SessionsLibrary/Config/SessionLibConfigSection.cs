using System;
using System.Configuration;
using System.Linq;

namespace SessionsLibrary
{
    public class SessionLibConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("sessionsData", IsDefaultCollection = false)]
        public SessionDataCollection SessionsData
        {
            get { return ((SessionDataCollection)(base["sessionsData"])); }
        }
    }
}
