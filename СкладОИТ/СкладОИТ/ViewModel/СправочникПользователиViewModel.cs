using DevExpress.Mvvm;
using DevExpress.Xpo;
using SessionsLibrary;
using System;
using System.Linq;
using СкладОИТ.XPO.СкладОИТ;


namespace СкладОИТ
{
    public class СправочникПользователиViewModel : ViewModelBase
    {
        Session _Session;
        public СправочникПользователиViewModel() { _Session = ConnectHelper.Session; }
        public Session Session => _Session;

        //public void DeleteCurrentRow(object row)
        //{
        //    if (row != null)
        //    {
        //        Session.Delete(row as Пользователь);
        //        Session.PurgeDeletedObjects();
        //    }
        //}


        /// <summary>
        /// удаление выбранного объекта 
        /// </summary>
        public void DeleteCurrentRow()
        {
            Session.PurgeDeletedObjects();
        }
    }
}
