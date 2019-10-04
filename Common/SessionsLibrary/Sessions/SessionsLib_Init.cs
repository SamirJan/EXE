using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace SessionsLibrary
{
    public partial class SessionsLib
    {
        public SessionsLib()
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            SessionLibConfigSection section;
            section = (SessionLibConfigSection)ConfigurationManager.GetSection("SessionLibConfigSection");

            if (section == null)
                throw new InvalidOperationException("Нет секции SessionLibConfigSection в конфигурации программы!");


            //перебор всех элементов конфига
            foreach (SessionDataElement element in section.SessionsData)
            {

                if (element.ThreadSafe)
                {
                    if (element.TypeLibs.Count == 0)
                        throw new Exception($"Для загрузки сесии в режиме ThreadSafe необходимо указать хотя бы одну библиотеку в разделе TypeLibs.Сессия Name ={ element.Name }");
                }

                List<Assembly> assembles = new List<Assembly>();
                foreach (TypeLibElement typeLib in element.TypeLibs)
                {
                    assembles.Add(Assembly.Load(typeLib.AssemblyName));
                }
                
                SessionData sessionData = this.CreateMSSQLSession(
                                                  element.Name,
                                                  element.ServerName,
                                                  element.DBName,
                                                  element.AutoCreateOption, element.ThreadSafe, assembles.ToArray());

                this.Add(sessionData);
            }
        }
    }
}
