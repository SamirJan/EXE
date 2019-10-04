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
using DevExpress.Data;

namespace СкладОИТ.View
{
    public partial class Справочник_Номенклатура : DevExpress.XtraEditors.XtraForm
    {
        СправочникНоменклатураViewModel _СправочникНоменклатураViewModel;
        public Справочник_Номенклатура()
        {
            InitializeComponent();

            mvvmContext1.ViewModelType = typeof(СправочникНоменклатураViewModel);
            _СправочникНоменклатураViewModel = mvvmContext1.GetViewModel<СправочникНоменклатураViewModel>();
            var fluent = mvvmContext1.OfType<СправочникНоменклатураViewModel>();

            //// удаление выделенной строки
            //fluent
            //    .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
            //    .EventToCommand(vm => vm.DeleteCurrentRow(null), new Func<RowDeletedEventArgs, object>(e => e.Row));

            // удаление выделенной строки
            fluent
                .WithEvent<RowDeletedEventArgs>(gridView1, "RowDeleted")
                .EventToCommand(vm => vm.DeleteCurrentRow());

        }

        private void XpCollection_Номенклатура_ResolveSession(object sender, DevExpress.Xpo.ResolveSessionEventArgs e)
        {
            e.Session = _СправочникНоменклатураViewModel.Session;
        }
    }
}