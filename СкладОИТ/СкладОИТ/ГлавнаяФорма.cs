using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using СкладОИТ.View;


namespace СкладОИТ
{
    public partial class ГлавнаяФорма : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AppИнфоViewModel _AppИнфоViewModel;
        public ГлавнаяФорма()
        {
            InitializeComponent();

            mvvmContext_AppИнфо.ViewModelType = typeof(AppИнфоViewModel);
            var fluent = mvvmContext_AppИнфо.OfType<AppИнфоViewModel>();

            _AppИнфоViewModel = mvvmContext_AppИнфо.GetViewModel<AppИнфоViewModel>();
            fluent.SetBinding(barStaticItem_userAccName, ds => ds.Caption, sp => sp.ДоменИмяПользвателя);
            fluent.SetBinding(barStaticItem_dbName, ds => ds.Caption, sp => sp.DBName);

            Timer timer = new Timer();
            timer.Enabled = true;

            timer.Tick += (s, e) =>
            {
                fluent.SetBinding(barStaticItem_ДатаВремя, ds => ds.Caption, sp => sp.ДатаВремя);
            };

            barButtonItem_Перезапустить.ItemClick += (s, e) => Application.Restart();
            barButtonItem_Закрыть.ItemClick += (s, e) => Close();

            


        }

        private void barButtonItem_СправочникОтделы_ItemClick(object sender, ItemClickEventArgs e)
        {
            Справочник_Отдел справочник_Отдел = new Справочник_Отдел();
            справочник_Отдел.MdiParent = this;
            справочник_Отдел.Show();
        }

        private void barButtonItem_СправочникПользователи_ItemClick(object sender, ItemClickEventArgs e)
        {
            Справочник_Пользователь справочник_Пользователь = new Справочник_Пользователь();
            справочник_Пользователь.MdiParent = this;
            справочник_Пользователь.Show();
        }

        private void barButtonItem_СправочникНоменклатура_ItemClick(object sender, ItemClickEventArgs e)
        {
            Справочник_Номенклатура справочник_Номенклатура = new Справочник_Номенклатура();
            справочник_Номенклатура.MdiParent = this;
            справочник_Номенклатура.Show();
        }

        private void barButtonItem_ВыданнаяНоменклатура_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm_ВыданнаяНоменклатура выданнаяНоменклатура = new XtraForm_ВыданнаяНоменклатура();
            выданнаяНоменклатура.MdiParent = this;
            выданнаяНоменклатура.Show();
        }

        private void BarButtonItem_ВыданнаяНоменклатура_ПродажаООО_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm_ВыданнаяНоменклатура_ПродажаООО выданнаяНоменклатураПродажаООО = new XtraForm_ВыданнаяНоменклатура_ПродажаООО();
            выданнаяНоменклатураПродажаООО.MdiParent = this;
            выданнаяНоменклатураПродажаООО.Show();
        }
    }
}