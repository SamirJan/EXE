using DevExpress.Mvvm;
using DevExpress.Xpo;
using SessionsLibrary;
using System;
using System.Linq;
using СкладОИТ.XPO.СкладОИТ;


namespace СкладОИТ
{
    public class СправочникНоменклатураViewModel : ViewModelBase
    {
        Session _Session;
        public СправочникНоменклатураViewModel() { _Session = ConnectHelper.Session; }
        public Session Session => _Session;

        ////удаление объекта выделенной строки
        //public void DeleteCurrentRow(object row)
        //{
        //    if (row != null)
        //    {
        //        Session.Delete(row as Номенклатура);
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
