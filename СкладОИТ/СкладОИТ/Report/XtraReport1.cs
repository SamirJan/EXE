using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace СкладОИТ.Report
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            ДатаНачало.Value = DateTime.Today.AddDays(-7);
            ДатаКонец.Value = DateTime.Today;
        }

        private void TableRow2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           string статус = this.GetCurrentColumnValue("Статус")?.ToString();
            switch (статус)
            {
                case "Инспектор":
                    tableRow2.BackColor = Color.LightPink;
                    break;
                case "Списание":
                    tableRow2.BackColor = Color.LightGreen;
                    break;
                case "Выдано":
                    tableRow2.BackColor = Color.White;
                    break;
            }
        }
    }
}
