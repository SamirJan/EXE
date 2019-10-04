using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using SessionsLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;
using СкладОИТ.XPO.СкладОИТ;


namespace СкладОИТ
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

#if DEBUG
            ConnectHelper.SetSession("СкладОИТDEBUG");
#else
            ConnectHelper.SetSession("СкладОИТ");
#endif

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ГлавнаяФорма());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // https://www.devexpress.com/Support/Center/Question/Details/A1630/why-are-objects-not-deleted-when-i-delete-them-in-the-xtragrid
            //TODO удаление в гриде https://documentation.devexpress.com/XPO/8921/Concepts/Explicit-Units-of-Work  последний пример
            //TODO Пересмотреть Сессию 

            //TODO  ServiceContainer.Default.GetService<IMessageBoxService> Удаление Наряда 
            //ViewModelНаряды
            //public void УдалитьТекущийНаряд()
            //{
            //    var service = GetService<IУдалениеНаряда>();
            //    service?.Delete(ТекущийНаряд);
            //}
            //XtraFormПутевыеЛисты fluentAPI_Наряды.BindCommand(simpleButton_ПутевойЛист_Удаление, x => x.УдалитьТекущийНаряд());

            //TODO SessionsLib, SessionsLib_Init, SessionsLib_SessionData

            //TODO Connections ConfigUrationManager.ConnectionStrings[].ConnectionString;

            //TODO TypeLib


            //Сделать ClickOnce
            //TODO вынести интерфейс удаления !!!!!!!!!!!!!!! абстрактный класс BO XPO нужно хорошо подумать
        }
    }
}
