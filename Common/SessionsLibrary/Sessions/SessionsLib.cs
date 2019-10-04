using System;
using System.Collections.Generic;
using System.Linq;

namespace SessionsLibrary
{
    public partial class SessionsLib
    {
        /// <summary>
        /// Хранилище библиотеки сесиий по умолчанию.
        /// </summary>
        static SessionsLib _Default;

        /// <summary>
        /// Список зарегестрированных сессий и их данных.
        /// Ключ формируется классом SessionData. 
        /// </summary>
        private readonly SortedList<string, SessionData> _SessionDates = new SortedList<string, SessionData>();

        /// <summary>
        /// Библиотека сессий по умолчанию.
        /// При создании автоматически загружается из конфигурации программы.
        /// </summary>
        public static SessionsLib Default
        {
            get
            {
                if (_Default == null)
                {
                    _Default = new SessionsLib();
                }
                return _Default;
            }
        }

        
    }
}
