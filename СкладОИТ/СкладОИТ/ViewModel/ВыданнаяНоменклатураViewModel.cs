﻿using DevExpress.Mvvm;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using SessionsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using СкладОИТ.XPO.СкладОИТ;
using СкладОИТ.Report;


namespace СкладОИТ
{
    public class ВыданнаяНоменклатураViewModel : ViewModelBase
    {
        Session _Session;
        public ВыданнаяНоменклатураViewModel() { _Session = ConnectHelper.Session; }
        public Array Cтатус
        {
            get { return Enum.GetValues(typeof(Enum_Статус)); }
        }
        public Session Session => _Session;

        ////удаление выбранного объекта
        //public void DeleteCurrentRow(object row)
        //{
        //    if (row != null)
        //    {
        //        Session.Delete(row as ВыданнаяНоменклатура);
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
        public void СоздатьОтчет()
        {
            //Session session = new Session()
            //{
            //    AutoCreateOption = AutoCreateOption.None,
            //    ConnectionString = XpoDefault.Session.ConnectionString
            //};

            //Session = SessionsLibrary.ConnectHelper.Session;

            var report = new XtraReport1();
            var выданнаяноменклатураXPO = Session.Query<ВыданнаяНоменклатура>();

            //инициализация класса ReportВыданнаяНоменклатура
            var выданнаяНоменклатура = выданнаяноменклатураXPO.Select(выд => new ReportВыданнаяНоменклатура()
            {
                Id = выд.Oid,
                ДатаВыдачи = выд.ДатаВыдачи,
                Количество = выд.Количество,
                Статус = выд.Статус,
                НоменклатураНаименование = выд.НоменклатураID.Наименование,
                НоменклатураСерияНомер = выд.НоменклатураID.Серияномер,
                ОтделНазвание = выд.ОтделID.Название,
                ПользовательФИО = выд.ПользовательID.ФИО
            }).ToList();

            report.DataSource = new BindingList<ReportВыданнаяНоменклатура>(выданнаяНоменклатура);
            DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(report);
            printTool.ShowRibbonPreview();
        }

        /*
        void MethodName()
        {
            //string constr = @"data source=pc-uoit146\sqlexpress01;integrated security=SSPI;initial catalog=СкладОИТ";
            //IDbConnection connection = new SqlConnection(constr);
            //IDataLayer layer = new SimpleDataLayer(new MSSqlConnectionProvider(connection, AutoCreateOption.DatabaseAndSchema));
            //Session = new Session(layer);

            #region Пример сессии

            //public SessionData(string logicName, string serverName, string DBName, AutoCreateOption autoCreateOption, bool threadSafe, params Assembly[] assembles)
            //{
            //    ThreadSafe = threadSafe;
            //    _LogicName = logicName;
            //    _ServerName = serverName;
            //    _DBName = DBName;
            //    AutoCreateOption = autoCreateOption;

            //    string sqlConn = MSSqlConnectionProvider.GetConnectionString(_ServerName, _DBName);
            //    _DataStore = XpoDefault.GetConnectionProvider(sqlConn, AutoCreateOption);

            //    if (ThreadSafe)
            //    {

            //        XPDictionary xpDictionary = new ReflectionDictionary();
            //        xpDictionary.CollectClassInfos(assembles);

            //        _DataLayer = new ThreadSafeDataLayer(xpDictionary, _DataStore);
            //    }
            //    else
            //    {
            //        if (assembles.Length == 0)
            //        {
            //            _DataLayer = new SimpleDataLayer(_DataStore);//XpoDefault.GetDataLayer(sqlConn, AutoCreateOption);
            //        }
            //        else
            //        {
            //            XPDictionary xpDictionary = new ReflectionDictionary();
            //            xpDictionary.CollectClassInfos(assembles);


            //            _DataLayer = new SimpleDataLayer(xpDictionary, _DataStore);// XpoDefault.GetDataLayer(sqlConn, xpDictionary, AutoCreateOption);

            //        }
            //    }

            //    Session session = new Session(_DataLayer, null);

            //    SetSession(session);
            //}



            //public SessionData CreateMSSQLSession(string logicName, string serverName, string DBName, AutoCreateOption autoCreateOption, Type providerType)
            //{
            //    return new SessionData(logicName, serverName, DBName, autoCreateOption, providerType);
            //}

            //    public SessionData this[string logicName]
            //{
            //    get
            //    {
            //        SessionData sessionData;
            //        if (!_SessionDates.TryGetValue(logicName, out sessionData))
            //        {
            //            string stringFormat = $"Запрошенно соединение ({logicName}), а его нету!\nРаботать не буду!";
            //            //MessageBox.Show(stringFormat, "Страшная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //            Process.GetCurrentProcess().Kill();
            //        }
            //        return _SessionDates[logicName];
            //    }
            //}


            //public static SessionsLib Default
            //{
            //    get
            //    {
            //        if (_Default == null)
            //        {
            //            _Default = new SessionsLib();
            //        }
            //        return _Default;
            //    }
            //}


            #endregion
        }*/
    }
}
