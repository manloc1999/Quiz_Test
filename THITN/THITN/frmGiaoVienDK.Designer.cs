
namespace THITN
{
    partial class frmGiaoVienDK
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel1;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.Windows.Forms.Label sOCAUTHILabel1;
            System.Windows.Forms.Label lANLabel1;
            System.Windows.Forms.Label mAGVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVienDK));
            this.dS = new THITN.DS();
            this.gIAOVIEN_DANGKYTableAdapter = new THITN.DSTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cbCS = new System.Windows.Forms.ComboBox();
            this.pncGVDK = new DevExpress.XtraEditors.PanelControl();
            this.txtMaGV = new DevExpress.XtraEditors.TextEdit();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spinLan = new DevExpress.XtraEditors.SpinEdit();
            this.spinSoCau = new DevExpress.XtraEditors.SpinEdit();
            this.spinThoiGian = new DevExpress.XtraEditors.SpinEdit();
            this.dptNgayThi = new DevExpress.XtraEditors.DateEdit();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new THITN.DSTableAdapters.MONHOCTableAdapter();
            this.gIAOVIENTableAdapter = new THITN.DSTableAdapters.GIAOVIENTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lOPTableAdapter = new THITN.DSTableAdapters.LOPTableAdapter();
            this.gcGiaoVienDK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel1 = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel1 = new System.Windows.Forms.Label();
            lANLabel1 = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncGVDK)).BeginInit();
            this.pncGVDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayThi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVienDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(70, 110);
            mAMHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(89, 21);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "TÊN MH :";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(60, 35);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(95, 21);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "TÊN LỚP :";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tRINHDOLabel.Location = new System.Drawing.Point(432, 46);
            tRINHDOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(109, 21);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "TRÌNH ĐỘ :";
            // 
            // nGAYTHILabel1
            // 
            nGAYTHILabel1.AutoSize = true;
            nGAYTHILabel1.Location = new System.Drawing.Point(432, 116);
            nGAYTHILabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYTHILabel1.Name = "nGAYTHILabel1";
            nGAYTHILabel1.Size = new System.Drawing.Size(112, 21);
            nGAYTHILabel1.TabIndex = 18;
            nGAYTHILabel1.Text = "NGÀY THI : ";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(838, 106);
            tHOIGIANLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(120, 21);
            tHOIGIANLabel.TabIndex = 19;
            tHOIGIANLabel.Text = "THỜI GIAN : ";
            // 
            // sOCAUTHILabel1
            // 
            sOCAUTHILabel1.AutoSize = true;
            sOCAUTHILabel1.Location = new System.Drawing.Point(826, 35);
            sOCAUTHILabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOCAUTHILabel1.Name = "sOCAUTHILabel1";
            sOCAUTHILabel1.Size = new System.Drawing.Size(129, 21);
            sOCAUTHILabel1.TabIndex = 20;
            sOCAUTHILabel1.Text = "SỐ CÂU THI : ";
            // 
            // lANLabel1
            // 
            lANLabel1.AutoSize = true;
            lANLabel1.Location = new System.Drawing.Point(449, 182);
            lANLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lANLabel1.Name = "lANLabel1";
            lANLabel1.Size = new System.Drawing.Size(61, 21);
            lANLabel1.TabIndex = 21;
            lANLabel1.Text = "LẦN : ";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(79, 191);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(80, 21);
            mAGVLabel.TabIndex = 22;
            mAGVLabel.Text = "MÃ GV :";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnRefresh,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 6;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1368, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1035);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1368, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 984);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1368, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 984);
            // 
            // cbCS
            // 
            this.cbCS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCS.FormattingEnabled = true;
            this.cbCS.Location = new System.Drawing.Point(860, 0);
            this.cbCS.Margin = new System.Windows.Forms.Padding(4);
            this.cbCS.Name = "cbCS";
            this.cbCS.Size = new System.Drawing.Size(150, 28);
            this.cbCS.TabIndex = 10;
            this.cbCS.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pncGVDK
            // 
            this.pncGVDK.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.pncGVDK.Controls.Add(this.txtMaGV);
            this.pncGVDK.Controls.Add(mAGVLabel);
            this.pncGVDK.Controls.Add(lANLabel1);
            this.pncGVDK.Controls.Add(this.spinLan);
            this.pncGVDK.Controls.Add(sOCAUTHILabel1);
            this.pncGVDK.Controls.Add(this.spinSoCau);
            this.pncGVDK.Controls.Add(tHOIGIANLabel);
            this.pncGVDK.Controls.Add(this.spinThoiGian);
            this.pncGVDK.Controls.Add(nGAYTHILabel1);
            this.pncGVDK.Controls.Add(this.dptNgayThi);
            this.pncGVDK.Controls.Add(this.cmbTenLop);
            this.pncGVDK.Controls.Add(this.cmbTenMH);
            this.pncGVDK.Controls.Add(tRINHDOLabel);
            this.pncGVDK.Controls.Add(this.cmbTrinhDo);
            this.pncGVDK.Controls.Add(mALOPLabel);
            this.pncGVDK.Controls.Add(mAMHLabel);
            this.pncGVDK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pncGVDK.Location = new System.Drawing.Point(0, 771);
            this.pncGVDK.Margin = new System.Windows.Forms.Padding(4);
            this.pncGVDK.Name = "pncGVDK";
            this.pncGVDK.Size = new System.Drawing.Size(1368, 264);
            this.pncGVDK.TabIndex = 11;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(225, 191);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGV.MenuManager = this.barManager1;
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(156, 26);
            this.txtMaGV.TabIndex = 23;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dS;
            // 
            // spinLan
            // 
            this.spinLan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "LAN", true));
            this.spinLan.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinLan.Location = new System.Drawing.Point(571, 179);
            this.spinLan.Margin = new System.Windows.Forms.Padding(4);
            this.spinLan.MenuManager = this.barManager1;
            this.spinLan.Name = "spinLan";
            this.spinLan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinLan.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinLan.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinLan.Size = new System.Drawing.Size(209, 26);
            this.spinLan.TabIndex = 22;
            // 
            // spinSoCau
            // 
            this.spinSoCau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "SOCAUTHI", true));
            this.spinSoCau.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSoCau.Location = new System.Drawing.Point(1005, 31);
            this.spinSoCau.Margin = new System.Windows.Forms.Padding(4);
            this.spinSoCau.MenuManager = this.barManager1;
            this.spinSoCau.Name = "spinSoCau";
            this.spinSoCau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoCau.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinSoCau.Size = new System.Drawing.Size(149, 26);
            this.spinSoCau.TabIndex = 21;
            // 
            // spinThoiGian
            // 
            this.spinThoiGian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "THOIGIAN", true));
            this.spinThoiGian.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinThoiGian.Location = new System.Drawing.Point(1005, 102);
            this.spinThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.spinThoiGian.MenuManager = this.barManager1;
            this.spinThoiGian.Name = "spinThoiGian";
            this.spinThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinThoiGian.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinThoiGian.Size = new System.Drawing.Size(149, 26);
            this.spinThoiGian.TabIndex = 20;
            // 
            // dptNgayThi
            // 
            this.dptNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAOVIEN_DANGKYBindingSource, "NGAYTHI", true));
            this.dptNgayThi.EditValue = null;
            this.dptNgayThi.Location = new System.Drawing.Point(576, 112);
            this.dptNgayThi.Margin = new System.Windows.Forms.Padding(4);
            this.dptNgayThi.MenuManager = this.barManager1;
            this.dptNgayThi.Name = "dptNgayThi";
            this.dptNgayThi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayThi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dptNgayThi.Size = new System.Drawing.Size(204, 26);
            this.dptNgayThi.TabIndex = 19;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gIAOVIEN_DANGKYBindingSource, "MALOP", true));
            this.cmbTenLop.DataSource = this.lOPBindingSource;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(225, 35);
            this.cmbTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(150, 28);
            this.cmbTenLop.TabIndex = 18;
            this.cmbTenLop.ValueMember = "MALOP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gIAOVIEN_DANGKYBindingSource, "MAMH", true));
            this.cmbTenMH.DataSource = this.mONHOCBindingSource;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(225, 110);
            this.cmbTenMH.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(150, 28);
            this.cmbTenMH.TabIndex = 17;
            this.cmbTenMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "TRINHDO", true));
            this.cmbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrinhDo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(576, 35);
            this.cmbTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(194, 28);
            this.cmbTrinhDo.TabIndex = 7;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(698, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cơ Sở";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbCS);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1368, 45);
            this.panelControl1.TabIndex = 27;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // gcGiaoVienDK
            // 
            this.gcGiaoVienDK.DataSource = this.gIAOVIEN_DANGKYBindingSource;
            this.gcGiaoVienDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcGiaoVienDK.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcGiaoVienDK.Location = new System.Drawing.Point(0, 96);
            this.gcGiaoVienDK.MainView = this.gridView1;
            this.gcGiaoVienDK.Margin = new System.Windows.Forms.Padding(4);
            this.gcGiaoVienDK.MenuManager = this.barManager1;
            this.gcGiaoVienDK.Name = "gcGiaoVienDK";
            this.gcGiaoVienDK.Size = new System.Drawing.Size(1368, 675);
            this.gcGiaoVienDK.TabIndex = 31;
            this.gcGiaoVienDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcGiaoVienDK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 31;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 117;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 31;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 117;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 31;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            this.colMALOP.Width = 117;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.MinWidth = 31;
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            this.colTRINHDO.Width = 117;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.MinWidth = 31;
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            this.colNGAYTHI.Width = 117;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.MinWidth = 31;
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            this.colLAN.Width = 117;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.MinWidth = 31;
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            this.colSOCAUTHI.Width = 117;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.MinWidth = 31;
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            this.colTHOIGIAN.Width = 117;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmGiaoVienDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1368, 1055);
            this.Controls.Add(this.gcGiaoVienDK);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pncGVDK);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoVienDK";
            this.Text = "frmGiaoVienDK";
            this.Load += new System.EventHandler(this.frmGiaoVienDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncGVDK)).EndInit();
            this.pncGVDK.ResumeLayout(false);
            this.pncGVDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinLan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayThi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dptNgayThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGiaoVienDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private DSTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.ComboBox cbCS;
        private DevExpress.XtraEditors.PanelControl pncGVDK;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DevExpress.XtraEditors.DateEdit dptNgayThi;
        private DevExpress.XtraEditors.SpinEdit spinLan;
        private DevExpress.XtraEditors.SpinEdit spinSoCau;
        private DevExpress.XtraEditors.SpinEdit spinThoiGian;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraGrid.GridControl gcGiaoVienDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.TextEdit txtMaGV;
    }
}