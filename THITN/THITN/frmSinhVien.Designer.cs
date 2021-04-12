namespace THITN
{
    partial class frmSinhVien
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCS = new System.Windows.Forms.ComboBox();
            this.dS = new THITN.DS();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new THITN.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new THITN.DSTableAdapters.LOPTableAdapter();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcSinhVien = new DevExpress.XtraGrid.GridControl();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelSinhVien = new DevExpress.XtraEditors.GroupControl();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.tbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.tbTen = new DevExpress.XtraEditors.TextEdit();
            this.tbHo = new DevExpress.XtraEditors.TextEdit();
            this.tbMaSV = new DevExpress.XtraEditors.TextEdit();
            mALOPLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSinhVien)).BeginInit();
            this.panelSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(552, 116);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 21);
            mALOPLabel.TabIndex = 22;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(551, 84);
            nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(88, 21);
            nGAYSINHLabel.TabIndex = 21;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(552, 51);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(69, 21);
            dIACHILabel.TabIndex = 20;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(132, 116);
            tENLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(43, 21);
            tENLabel.TabIndex = 19;
            tENLabel.Text = "Tên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(132, 83);
            hOLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(37, 21);
            hOLabel.TabIndex = 18;
            hOLabel.Text = "Họ:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(132, 51);
            mASVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(66, 21);
            mASVLabel.TabIndex = 17;
            mASVLabel.Text = "Mã SV:";
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
            this.barCheckItem1,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Offset = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 6;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.LargeImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 8;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(1143, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 678);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1143, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 627);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1143, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 627);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 4;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbCS);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 51);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 70);
            this.groupControl1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cơ sở";
            // 
            // cbCS
            // 
            this.cbCS.DisplayMember = "TENCS";
            this.cbCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCS.FormattingEnabled = true;
            this.cbCS.Location = new System.Drawing.Point(461, 32);
            this.cbCS.Margin = new System.Windows.Forms.Padding(2);
            this.cbCS.Name = "cbCS";
            this.cbCS.Size = new System.Drawing.Size(152, 29);
            this.cbCS.TabIndex = 0;
            this.cbCS.ValueMember = "TENSERVER";
            this.cbCS.SelectedIndexChanged += new System.EventHandler(this.cbCS_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcLop);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 121);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1143, 149);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Lớp";
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcLop.Location = new System.Drawing.Point(2, 28);
            this.gcLop.MainView = this.gridView1;
            this.gcLop.Margin = new System.Windows.Forms.Padding(2);
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1139, 119);
            this.gcLop.TabIndex = 0;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 241;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gcLop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcSinhVien);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 270);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1143, 240);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Sinh viên";
            // 
            // gcSinhVien
            // 
            this.gcSinhVien.DataSource = this.sINHVIENBindingSource;
            this.gcSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSinhVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcSinhVien.Location = new System.Drawing.Point(2, 28);
            this.gcSinhVien.MainView = this.gridView2;
            this.gcSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.gcSinhVien.MenuManager = this.barManager1;
            this.gcSinhVien.Name = "gcSinhVien";
            this.gcSinhVien.Size = new System.Drawing.Size(1139, 210);
            this.gcSinhVien.TabIndex = 0;
            this.gcSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.sINHVIENBindingSource.DataSource = this.bdsLop;
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 241;
            this.gridView2.FixedLineWidth = 1;
            this.gridView2.GridControl = this.gcSinhVien;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // panelSinhVien
            // 
            this.panelSinhVien.Controls.Add(this.cbMaLop);
            this.panelSinhVien.Controls.Add(this.tbDiaChi);
            this.panelSinhVien.Controls.Add(this.dtNgaySinh);
            this.panelSinhVien.Controls.Add(this.tbTen);
            this.panelSinhVien.Controls.Add(this.tbHo);
            this.panelSinhVien.Controls.Add(this.tbMaSV);
            this.panelSinhVien.Controls.Add(mALOPLabel);
            this.panelSinhVien.Controls.Add(nGAYSINHLabel);
            this.panelSinhVien.Controls.Add(dIACHILabel);
            this.panelSinhVien.Controls.Add(tENLabel);
            this.panelSinhVien.Controls.Add(hOLabel);
            this.panelSinhVien.Controls.Add(mASVLabel);
            this.panelSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSinhVien.Location = new System.Drawing.Point(0, 510);
            this.panelSinhVien.Margin = new System.Windows.Forms.Padding(2);
            this.panelSinhVien.Name = "panelSinhVien";
            this.panelSinhVien.Size = new System.Drawing.Size(1143, 168);
            this.panelSinhVien.TabIndex = 34;
            // 
            // cbMaLop
            // 
            this.cbMaLop.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "MALOP", true));
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(633, 113);
            this.cbMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(178, 28);
            this.cbMaLop.TabIndex = 34;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.tbDiaChi.Location = new System.Drawing.Point(633, 48);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbDiaChi.MenuManager = this.barManager1;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(176, 26);
            this.tbDiaChi.TabIndex = 33;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dtNgaySinh.EditValue = null;
            this.dtNgaySinh.Location = new System.Drawing.Point(633, 82);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgaySinh.MenuManager = this.barManager1;
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgaySinh.Size = new System.Drawing.Size(176, 26);
            this.dtNgaySinh.TabIndex = 32;
            // 
            // tbTen
            // 
            this.tbTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.tbTen.Location = new System.Drawing.Point(196, 113);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2);
            this.tbTen.MenuManager = this.barManager1;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(176, 26);
            this.tbTen.TabIndex = 31;
            // 
            // tbHo
            // 
            this.tbHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.tbHo.Location = new System.Drawing.Point(196, 82);
            this.tbHo.Margin = new System.Windows.Forms.Padding(2);
            this.tbHo.MenuManager = this.barManager1;
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(176, 26);
            this.tbHo.TabIndex = 30;
            // 
            // tbMaSV
            // 
            this.tbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.tbMaSV.Location = new System.Drawing.Point(196, 48);
            this.tbMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaSV.MenuManager = this.barManager1;
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(176, 26);
            this.tbMaSV.TabIndex = 29;
            // 
            // frmSinhVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 698);
            this.Controls.Add(this.panelSinhVien);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSinhVien)).EndInit();
            this.panelSinhVien.ResumeLayout(false);
            this.panelSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsSV;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCS;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl panelSinhVien;
        private System.Windows.Forms.ComboBox cbMaLop;
        private DevExpress.XtraEditors.TextEdit tbDiaChi;
        private DevExpress.XtraEditors.DateEdit dtNgaySinh;
        private DevExpress.XtraEditors.TextEdit tbTen;
        private DevExpress.XtraEditors.TextEdit tbHo;
        private DevExpress.XtraEditors.TextEdit tbMaSV;
        private DevExpress.XtraGrid.GridControl gcSinhVien;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}