using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СкладОИТ.Report
{
    public class ReportВыданнаяНоменклатура
    {
        public int Id { get; set; }
        public DateTime ДатаВыдачи { get; set; }
        public byte Количество { get; set; }
        public string Статус { get; set; }
        public string НоменклатураНаименование { get; set; }
        public string НоменклатураСерияНомер { get; set; }
        public string ОтделНазвание { get; set; }
        public string ПользовательФИО { get; set; }
    }
}
