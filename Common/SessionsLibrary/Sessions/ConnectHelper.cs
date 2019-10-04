using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace SessionsLibrary
{
    public class ConnectHelper
    {
        private static Session _Session;
        private static string _DBName;

        static SessionData sessionData;
        public static void SetSession(string sessionName)
        {
            sessionData = SessionsLib.Default[sessionName];
            _DBName = sessionData.DBName;
            _Session = sessionData.Session;
        }
        public static DevExpress.Xpo.Session Session => _Session;
        public static string DBName => _DBName;
    }
}
