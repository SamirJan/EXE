using DevExpress.Xpo.DB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace SessionsLibrary
{
    public partial class SessionsLib : IList<SessionData>
    {

        /// <summary>
        /// Добавление сессии и связь её с базой данных по имени базы даных и имени сервера.
        /// Также задаётся режим создания базы.
        /// </summary>
        /// <returns></returns>
        public SessionData CreateMSSQLSession(string logicName, string serverName, string dbName, AutoCreateOption autoCreateOption, bool threadSafe, params Assembly[] assembles)
        {
            return new SessionData(logicName, serverName, dbName, autoCreateOption, threadSafe, assembles);
        }
        /// <summary>
        /// /// Список всех соединений.
        /// </summary>
        public IList<SessionData> SessionsDates => _SessionDates.Values;



        public SessionData this[string logicName]
        {
            get
            {
                SessionData sessionData;
                if (!_SessionDates.TryGetValue(logicName, out sessionData))
                {
                    string сообщение = $"Запрошенное соединение ({logicName}) отсутствует!\nРаботать не буду!";
                    Process.GetCurrentProcess().Kill();
                }
                return _SessionDates[logicName];
            }
        }

        #region IList
        public int Count => _SessionDates.Count;

        public bool IsReadOnly => false;

        public SessionData this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(SessionData item)
        {
            _SessionDates.Add(item.LogicName, item);
        }

        public void Clear()
        {
            _SessionDates.Clear();
        }

        public bool Contains(SessionData item)
        {
            return _SessionDates.ContainsKey(item.LogicName);
        }

        public void CopyTo(SessionData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<SessionData> GetEnumerator()
        {
            return _SessionDates.Values.GetEnumerator();
        }

        public int IndexOf(SessionData item)
        {
            return _SessionDates.IndexOfValue(item);
        }

        public void Insert(int index, SessionData item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(SessionData item)
        {
            return _SessionDates.Remove(item.LogicName);
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _SessionDates.Values.GetEnumerator();
        }
        #endregion
    }
}
