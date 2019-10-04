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
using DevExpress.Data;

namespace СкладОИТ.View
{
    public partial class Справочник_Пользователь : DevExpress.XtraEditors.XtraForm
    {
        СправочникПользователиViewModel _СправочникПользователиViewModel;
        public Справочник_Пользователь()
        {
            InitializeComponent();

            mvvmContext1.ViewModelType = typeof(СправочникПользователиViewModel);
            var fluent = mvvmContext1.OfType<СправочникПользователиViewModel>();
            _СправочникПользователиViewModel = mvvmContext1.GetViewModel<СправочникПользователиViewModel>();

            //// удаление выделенной строки
            //fluent
            //    .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
            //    .EventToCommand(vm => vm.DeleteCurrentRow(null), new Func<RowDeletedEventArgs, object>(e => e.Row));

            // удаление выделенной строки
            fluent
                .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
                .EventToCommand(vm => vm.DeleteCurrentRow());
        }

        private void XpCollection_Пользователь_ResolveSession(object sender, ResolveSessionEventArgs e)
        {
            e.Session = _СправочникПользователиViewModel.Session;
        }
    }
}