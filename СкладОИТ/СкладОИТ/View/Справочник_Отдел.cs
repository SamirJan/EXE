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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data;

namespace СкладОИТ
{
    public partial class Справочник_Отдел : DevExpress.XtraEditors.XtraForm
    {
        СправочникОтделыViewModel _СправочникОтделыViewModel;
        public Справочник_Отдел()
        {
            InitializeComponent();

            mvvmContext1.ViewModelType = typeof(СправочникОтделыViewModel);
            var fluent = mvvmContext1.OfType<СправочникОтделыViewModel>();
            _СправочникОтделыViewModel = mvvmContext1.GetViewModel<СправочникОтделыViewModel>();

            //// удаление выделенной строки
            //fluent
            //    .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
            //    .EventToCommand(vm => vm.DeleteCurrentRow(null), new Func<RowDeletedEventArgs, object>(e => e.Row));
            
            // удаление выделенной строки
            fluent
                .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
                .EventToCommand(vm => vm.DeleteCurrentRow());
        }

        private void XpCollection_Отдел_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e)
        {
            e.Session = _СправочникОтделыViewModel.Session;
        }
    }
}