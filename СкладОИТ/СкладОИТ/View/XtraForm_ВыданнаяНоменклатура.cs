using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using СкладОИТ.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.Data;

namespace СкладОИТ.View
{
    public partial class XtraForm_ВыданнаяНоменклатура : XtraForm
    {
        ВыданнаяНоменклатураViewModel _СправочникВыданнаяНоменклатураViewModel;
        #region Конструктор
        public XtraForm_ВыданнаяНоменклатура()
        {
            InitializeComponent();

            if (!mvvmContext1.IsDesignMode)
                Init();

        }
        #endregion

        void Init()
        {
            mvvmContext1.ViewModelType = typeof(ВыданнаяНоменклатураViewModel);
            var fluent = mvvmContext1.OfType<ВыданнаяНоменклатураViewModel>();
            _СправочникВыданнаяНоменклатураViewModel = mvvmContext1.GetViewModel<ВыданнаяНоменклатураViewModel>();

            repositoryItemComboBox_Статус.Items.AddRange(fluent.ViewModel.Cтатус);

            //// удаление выделенной строки
            //fluent
            //    .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
            //    .EventToCommand(vm => vm.DeleteCurrentRow(null), new Func<RowDeletedEventArgs, object>(e => e.Row));
            
            // удаление выделенной строки
            fluent
                .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
                .EventToCommand(vm => vm.DeleteCurrentRow());


            // Выделение строк в зависимости от статуса
            gridView1.RowStyle += (s, e) =>
            {
                if (e.RowHandle >= 0)
                {
                    string статус = gridView1.GetRowCellValue(e.RowHandle, "Статус")?.ToString();
                    if (статус != null)
                    {
                        if (статус == "Инспектор")
                        {
                            e.Appearance.ForeColor = Color.OrangeRed;
                        }
                        else if (статус == "Списание")
                        {
                            e.Appearance.ForeColor = Color.Green;
                        }
                        else if (статус == "Выдано")
                        {
                            e.Appearance.ForeColor = Color.Black;
                        }
                    }
                }
            };

            //экспорт в файл
            #region экспорт в файл
            //exportToToolStripMenuItem.Click += (s, e) =>
            //{
            //    if (xtraSaveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = xtraSaveFileDialog.FileName;
            //        string fileExtension = new System.IO.FileInfo(fileName).Extension;
            //        switch (fileExtension)
            //        {
            //            case ".docx":
            //                gridView1.ExportToDocx(xtraSaveFileDialog.FileName);
            //                break;
            //            case ".pdf":
            //                gridView1.ExportToPdf(xtraSaveFileDialog.FileName);
            //                break;
            //            case ".xlsx":
            //                gridView1.ExportToXlsx(xtraSaveFileDialog.FileName);
            //                break;
            //            case ".csv":
            //                gridView1.ExportToCsv(xtraSaveFileDialog.FileName);
            //                break;
            //            case ".txt":
            //                gridView1.ExportToText(xtraSaveFileDialog.FileName);
            //                break;
            //            case ".rtf":
            //                gridView1.ExportToRtf(xtraSaveFileDialog.FileName);
            //                break;
            //            case ".html":
            //                gridView1.ExportToHtml(xtraSaveFileDialog.FileName);
            //                break;
            //        }
            //        if (XtraMessageBox.Show("Вы хотите открыть этот файл?", "Экспорт документа", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //        {
            //            System.Diagnostics.Process.Start(xtraSaveFileDialog.FileName);
            //        }
            //    }
            //};
            #endregion

            // Создание отчёта
            reportToolStripMenuItem.Click += (s, e) =>
            {
                _СправочникВыданнаяНоменклатураViewModel.СоздатьОтчет();
            };
        }

        private void XpCollection_ВыданнаяНоменклатура_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = _СправочникВыданнаяНоменклатураViewModel.Session;
        }
    }
}