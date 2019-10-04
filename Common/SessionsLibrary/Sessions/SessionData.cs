using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using System;
using System.Linq;
using System.Reflection;

namespace SessionsLibrary
{
    public class SessionData : IComparable
    {
        #region Поля
        /// <summary>
        /// Имя соединения
        /// </summary>
        private string _LogicName;

        /// <summary>
        /// Имя сервера
        /// </summary>
        private string _ServerName;

        /// <summary>
        /// Имя базы данных на сервере
        /// </summary>
        private string _DBName;

        /// <summary>
        /// Варианты создания базы и схемы
        /// </summary>
        private AutoCreateOption _AutoCreateOption;

        /// <summary>
        /// Взаимодействие с хранилищем данных
        /// </summary>
        private IDataStore _DataStore;

        /// <summary>
        /// Слой доступа к базе данных
        /// </summary>
        private IDataLayer _DataLayer;

        /// <summary>
        /// Сеанс подключения
        /// </summary>
        private Session _Session;

        #endregion

        #region Свойства

        /// <summary>
        /// Имя соединения
        /// </summary>
        public string LogicName => _LogicName;

        /// <summary>
        /// Имя сервера
        /// </summary>
        public string ServerName => _ServerName;

        /// <summary>
        /// Имя базы данных на сервере
        /// </summary>
        public string DBName => _DBName;

        /// <summary>
        /// Варианты создания базы и схемы
        /// </summary>
        public AutoCreateOption AutoCreateOption => _AutoCreateOption;

        /// <summary>
        /// Слой доступа к базе данных
        /// </summary>
        public IDataLayer DataLayer => _DataLayer;

        /// <summary>
        /// Сеанс подключения
        /// </summary>
        public Session Session => _Session;

        /// <summary>
        /// Флаг потокобезопасности
        /// </summary>
        public bool ThreadSafe { get; private set; }
        #endregion

        public SessionData(string logicName, string serverName, string dbName, AutoCreateOption autoCreateOption, bool threadSafe, params Assembly[] assembles)
        {
            ThreadSafe = threadSafe;
            _LogicName = logicName;
            _ServerName = serverName;
            _DBName = dbName;
            _AutoCreateOption = autoCreateOption;

            string sqlConnectionString = MSSqlConnectionProvider.GetConnectionString(_ServerName, _DBName);
            _DataStore = XpoDefault.GetConnectionProvider(sqlConnectionString, autoCreateOption);

            if (ThreadSafe)
            {
                XPDictionary xpDictionary = new ReflectionDictionary();
                xpDictionary.CollectClassInfos(assembles);

                _DataLayer = new ThreadSafeDataLayer(xpDictionary, _DataStore);
            }
            else
            {
                if (assembles?.Length == 0)
                {
                    _DataLayer = new SimpleDataLayer(_DataStore);
                }
                else
                {
                    XPDictionary xpDictionary = new ReflectionDictionary();
                    xpDictionary.CollectClassInfos(assembles);

                    _DataLayer = new SimpleDataLayer(xpDictionary, _DataStore);
                }
            }
            _Session = new Session(_DataLayer, null);
        }

        public int CompareTo(object obj) => string.Compare(this.LogicName, ((SessionData)obj).LogicName);

        public override string ToString() => $"ConnectName:{LogicName}; Server:{ServerName}; DataBase:{DBName}";
    }
}
