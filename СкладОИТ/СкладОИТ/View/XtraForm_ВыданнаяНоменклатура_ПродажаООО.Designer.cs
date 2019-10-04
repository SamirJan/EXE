namespace СкладОИТ.View
{
    partial class XtraForm_ВыданнаяНоменклатура_ПродажаООО
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpCollection_ВыданнаяНоменклатураПродажаООО = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colДатаВыдачи = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit_ДатаВыдачи = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colНоменклатура = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Номенклатура = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpCollection_Номенклатура = new DevExpress.Xpo.XPCollection(this.components);
            this.colСерияНомер = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colКоличество = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colПользователь = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Пользователь = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpCollection_Пользователь = new DevExpress.Xpo.XPCollection(this.components);
            this.colОтдел = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Отдел = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xpCollection_Отдел = new DevExpress.Xpo.XPCollection(this.components);
            this.colСтатус = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox_Статус = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtraSaveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_ВыданнаяНоменклатураПродажаООО)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_ДатаВыдачи)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_ДатаВыдачи.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Номенклатура)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Номенклатура)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Пользователь)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Пользователь)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Отдел)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Отдел)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_Статус)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(974, 337);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection_ВыданнаяНоменклатураПродажаООО;
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl1.Location = new System.Drawing.Point(8, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit_Отдел,
            this.repositoryItemLookUpEdit_Пользователь,
            this.repositoryItemLookUpEdit_Номенклатура,
            this.repositoryItemDateEdit_ДатаВыдачи,
            this.repositoryItemComboBox_Статус});
            this.gridControl1.Size = new System.Drawing.Size(958, 317);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpCollection_ВыданнаяНоменклатураПродажаООО
            // 
            this.xpCollection_ВыданнаяНоменклатураПродажаООО.DeleteObjectOnRemove = true;
            this.xpCollection_ВыданнаяНоменклатураПродажаООО.ObjectType = typeof(XPO.СкладОИТ.ВыданнаяНоменклатура_ПродажаООО);
            this.xpCollection_ВыданнаяНоменклатураПродажаООО.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.XpCollection_ВыданнаяНоменклатураПродажаООО_ResolveSession);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.DetailTip.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.DetailTip.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colДатаВыдачи,
            this.colНоменклатура,
            this.colСерияНомер,
            this.colКоличество,
            this.colПользователь,
            this.colОтдел,
            this.colСтатус});
            this.gridView1.DetailHeight = 268;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.MinWidth = 15;
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            this.colOid.Width = 46;
            // 
            // colДатаВыдачи
            // 
            this.colДатаВыдачи.Caption = "Дата выдачи";
            this.colДатаВыдачи.ColumnEdit = this.repositoryItemDateEdit_ДатаВыдачи;
            this.colДатаВыдачи.FieldName = "ДатаВыдачи";
            this.colДатаВыдачи.MinWidth = 15;
            this.colДатаВыдачи.Name = "colДатаВыдачи";
            this.colДатаВыдачи.Visible = true;
            this.colДатаВыдачи.VisibleIndex = 1;
            this.colДатаВыдачи.Width = 79;
            // 
            // repositoryItemDateEdit_ДатаВыдачи
            // 
            this.repositoryItemDateEdit_ДатаВыдачи.AutoHeight = false;
            this.repositoryItemDateEdit_ДатаВыдачи.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_ДатаВыдачи.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit_ДатаВыдачи.Name = "repositoryItemDateEdit_ДатаВыдачи";
            // 
            // colНоменклатура
            // 
            this.colНоменклатура.Caption = "Номенклатура";
            this.colНоменклатура.ColumnEdit = this.repositoryItemLookUpEdit_Номенклатура;
            this.colНоменклатура.FieldName = "НоменклатураID!Key";
            this.colНоменклатура.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colНоменклатура.MinWidth = 15;
            this.colНоменклатура.Name = "colНоменклатура";
            this.colНоменклатура.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colНоменклатура.Visible = true;
            this.colНоменклатура.VisibleIndex = 2;
            this.colНоменклатура.Width = 274;
            // 
            // repositoryItemLookUpEdit_Номенклатура
            // 
            this.repositoryItemLookUpEdit_Номенклатура.AutoHeight = false;
            this.repositoryItemLookUpEdit_Номенклатура.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Номенклатура.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Наименование", "Наименование", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit_Номенклатура.DataSource = this.xpCollection_Номенклатура;
            this.repositoryItemLookUpEdit_Номенклатура.DisplayMember = "Наименование";
            this.repositoryItemLookUpEdit_Номенклатура.Name = "repositoryItemLookUpEdit_Номенклатура";
            this.repositoryItemLookUpEdit_Номенклатура.NullText = "";
            this.repositoryItemLookUpEdit_Номенклатура.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemLookUpEdit_Номенклатура.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit_Номенклатура.ValueMember = "Oid";
            // 
            // xpCollection_Номенклатура
            // 
            this.xpCollection_Номенклатура.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.xpCollection_Номенклатура.DeleteObjectOnRemove = true;
            this.xpCollection_Номенклатура.ObjectType = typeof(XPO.СкладОИТ.Номенклатура);
            this.xpCollection_Номенклатура.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.XpCollection_ВыданнаяНоменклатураПродажаООО_ResolveSession);
            // 
            // colСерияНомер
            // 
            this.colСерияНомер.Caption = "Серия Номер";
            this.colСерияНомер.FieldName = "НоменклатураID.Серияномер";
            this.colСерияНомер.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colСерияНомер.MinWidth = 15;
            this.colСерияНомер.Name = "colСерияНомер";
            this.colСерияНомер.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colСерияНомер.Visible = true;
            this.colСерияНомер.VisibleIndex = 3;
            this.colСерияНомер.Width = 83;
            // 
            // colКоличество
            // 
            this.colКоличество.Caption = "Количество";
            this.colКоличество.FieldName = "Количество";
            this.colКоличество.MinWidth = 15;
            this.colКоличество.Name = "colКоличество";
            this.colКоличество.Visible = true;
            this.colКоличество.VisibleIndex = 4;
            this.colКоличество.Width = 78;
            // 
            // colПользователь
            // 
            this.colПользователь.Caption = "Пользователь";
            this.colПользователь.ColumnEdit = this.repositoryItemLookUpEdit_Пользователь;
            this.colПользователь.FieldName = "ПользовательID!Key";
            this.colПользователь.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colПользователь.MinWidth = 15;
            this.colПользователь.Name = "colПользователь";
            this.colПользователь.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colПользователь.Visible = true;
            this.colПользователь.VisibleIndex = 5;
            this.colПользователь.Width = 178;
            // 
            // repositoryItemLookUpEdit_Пользователь
            // 
            this.repositoryItemLookUpEdit_Пользователь.AutoHeight = false;
            this.repositoryItemLookUpEdit_Пользователь.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Пользователь.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ФИО", "ФИО", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit_Пользователь.DataSource = this.xpCollection_Пользователь;
            this.repositoryItemLookUpEdit_Пользователь.DisplayMember = "ФИО";
            this.repositoryItemLookUpEdit_Пользователь.Name = "repositoryItemLookUpEdit_Пользователь";
            this.repositoryItemLookUpEdit_Пользователь.NullText = "";
            this.repositoryItemLookUpEdit_Пользователь.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemLookUpEdit_Пользователь.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit_Пользователь.ValueMember = "Oid";
            // 
            // xpCollection_Пользователь
            // 
            this.xpCollection_Пользователь.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.xpCollection_Пользователь.DeleteObjectOnRemove = true;
            this.xpCollection_Пользователь.ObjectType = typeof(XPO.СкладОИТ.Пользователь);
            this.xpCollection_Пользователь.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.XpCollection_ВыданнаяНоменклатураПродажаООО_ResolveSession);
            // 
            // colОтдел
            // 
            this.colОтдел.Caption = "Отдел";
            this.colОтдел.ColumnEdit = this.repositoryItemLookUpEdit_Отдел;
            this.colОтдел.FieldName = "ОтделID!Key";
            this.colОтдел.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colОтдел.MinWidth = 15;
            this.colОтдел.Name = "colОтдел";
            this.colОтдел.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colОтдел.Visible = true;
            this.colОтдел.VisibleIndex = 6;
            this.colОтдел.Width = 208;
            // 
            // repositoryItemLookUpEdit_Отдел
            // 
            this.repositoryItemLookUpEdit_Отдел.AutoHeight = false;
            this.repositoryItemLookUpEdit_Отдел.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Отдел.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Название", "Название", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit_Отдел.DataSource = this.xpCollection_Отдел;
            this.repositoryItemLookUpEdit_Отдел.DisplayMember = "Название";
            this.repositoryItemLookUpEdit_Отдел.Name = "repositoryItemLookUpEdit_Отдел";
            this.repositoryItemLookUpEdit_Отдел.NullText = "";
            this.repositoryItemLookUpEdit_Отдел.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.repositoryItemLookUpEdit_Отдел.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit_Отдел.ValueMember = "Oid";
            // 
            // xpCollection_Отдел
            // 
            this.xpCollection_Отдел.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
            this.xpCollection_Отдел.DeleteObjectOnRemove = true;
            this.xpCollection_Отдел.ObjectType = typeof(XPO.СкладОИТ.Отдел);
            this.xpCollection_Отдел.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(this.XpCollection_ВыданнаяНоменклатураПродажаООО_ResolveSession);
            // 
            // colСтатус
            // 
            this.colСтатус.ColumnEdit = this.repositoryItemComboBox_Статус;
            this.colСтатус.FieldName = "Статус";
            this.colСтатус.MinWidth = 15;
            this.colСтатус.Name = "colСтатус";
            this.colСтатус.Visible = true;
            this.colСтатус.VisibleIndex = 7;
            this.colСтатус.Width = 93;
            // 
            // repositoryItemComboBox_Статус
            // 
            this.repositoryItemComboBox_Статус.AutoHeight = false;
            this.repositoryItemComboBox_Статус.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox_Статус.Name = "repositoryItemComboBox_Статус";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(974, 337);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(960, 321);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Visible = false;
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reportToolStripMenuItem.Text = "Сформировать отчёт";
            // 
            // xtraSaveFileDialog
            // 
            this.xtraSaveFileDialog.FileName = "Новый документ";
            this.xtraSaveFileDialog.Filter = "Документ Word (*.docx)|*.docx|PDF (*.pdf)|*.pdf|Книга Excel (*.xlsx)|*.xlsx|CSV (" +
    "*.csv)|*.csv|Обычный текст (*.txt)|*.txt|Текст в формате RTF (*.rtf)|*.rtf|Веб-с" +
    "траница (*.html)|*.html";
            this.xtraSaveFileDialog.InitialDirectory = "C:\\\\";
            this.xtraSaveFileDialog.Title = "Сохранение документа";
            // 
            // XtraForm_ВыданнаяНоменклатура_ПродажаООО
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 361);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XtraForm_ВыданнаяНоменклатура_ПродажаООО";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа ООО";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_ВыданнаяНоменклатураПродажаООО)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_ДатаВыдачи.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit_ДатаВыдачи)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Номенклатура)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Номенклатура)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Пользователь)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Пользователь)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Отдел)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Отдел)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox_Статус)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Xpo.XPCollection xpCollection_ВыданнаяНоменклатураПродажаООО;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colДатаВыдачи;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit_ДатаВыдачи;
        private DevExpress.XtraGrid.Columns.GridColumn colКоличество;
        private DevExpress.XtraGrid.Columns.GridColumn colНоменклатура;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Номенклатура;
        private DevExpress.Xpo.XPCollection xpCollection_Номенклатура;
        private DevExpress.XtraGrid.Columns.GridColumn colПользователь;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Пользователь;
        private DevExpress.Xpo.XPCollection xpCollection_Пользователь;
        private DevExpress.XtraGrid.Columns.GridColumn colОтдел;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Отдел;
        private DevExpress.Xpo.XPCollection xpCollection_Отдел;
        private DevExpress.XtraGrid.Columns.GridColumn colСтатус;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox_Статус;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colСерияНомер;
    }
}