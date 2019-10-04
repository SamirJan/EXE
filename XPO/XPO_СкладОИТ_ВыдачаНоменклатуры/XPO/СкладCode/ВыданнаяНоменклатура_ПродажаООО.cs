using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace СкладОИТ.XPO.СкладОИТ
{

    public partial class ВыданнаяНоменклатура_ПродажаООО
    {
        public ВыданнаяНоменклатура_ПродажаООО(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
