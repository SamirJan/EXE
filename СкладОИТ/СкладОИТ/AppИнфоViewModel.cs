using DevExpress.Mvvm;
using SessionsLibrary;
using System;
using System.Linq;


namespace СкладОИТ
{
    public class AppИнфоViewModel : ViewModelBase
    {
        
        public AppИнфоViewModel() { }
        
        string GetДоменИмяПользователя()
        {
            string домен = Environment.UserDomainName;
            string имяПользователя = Environment.UserName;
            return $@"Пользователь: {домен}\{имяПользователя}";
        }

        string GetDateTime()
        {
            var дата = DateTime.Now.ToString("dd.MM.yyyy");
            var время = DateTime.Now.ToString("H:mm:ss");
            return $"Дата: {дата} || Время: {время}";
        }
            
        
        public string ДоменИмяПользвателя => GetДоменИмяПользователя();
        public string DBName => $"DB_Name: {ConnectHelper.DBName}";
        public string ДатаВремя => GetDateTime();




    }
}