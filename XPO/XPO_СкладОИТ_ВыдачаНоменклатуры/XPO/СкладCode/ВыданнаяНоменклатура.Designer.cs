﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace СкладОИТ.XPO.СкладОИТ
{

    [DeferredDeletion(false)]
    [Persistent(@"Склад.ВыданнаяНоменклатура")]
    public partial class ВыданнаяНоменклатура : XPObject
    {
        DateTime fДатаВыдачи;
        public DateTime ДатаВыдачи
        {
            get { return fДатаВыдачи; }
            set { SetPropertyValue<DateTime>(nameof(ДатаВыдачи), ref fДатаВыдачи, value); }
        }
        byte fКоличество;
        public byte Количество
        {
            get { return fКоличество; }
            set { SetPropertyValue<byte>(nameof(Количество), ref fКоличество, value); }
        }
        string fСтатус;
        public string Статус
        {
            get { return fСтатус; }
            set { SetPropertyValue<string>(nameof(Статус), ref fСтатус, value); }
        }
        Номенклатура fНоменклатураID;
        [Association(@"ВыданнаяНоменклатура-Номенклатура")]
        public Номенклатура НоменклатураID
        {
            get { return fНоменклатураID; }
            set { SetPropertyValue<Номенклатура>(nameof(НоменклатураID), ref fНоменклатураID, value); }
        }
        Пользователь fПользовательID;
        [Association(@"ВыданнаяНоменклатура-Пользователь")]
        public Пользователь ПользовательID
        {
            get { return fПользовательID; }
            set { SetPropertyValue<Пользователь>(nameof(ПользовательID), ref fПользовательID, value); }
        }
        Отдел fОтделID;
        [Association(@"ВыданнаяНоменклатура-Отдел")]
        public Отдел ОтделID
        {
            get { return fОтделID; }
            set { SetPropertyValue<Отдел>(nameof(ОтделID), ref fОтделID, value); }
        }
    }

}
