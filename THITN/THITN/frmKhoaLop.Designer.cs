
namespace THITN
{
    partial class frmKhoaLop
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
            System.Windows.Forms.Label mAKHLabel1;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoaLop));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarSubItem();
            this.btnThemKhoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new THITN.DS();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new THITN.DSTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new THITN.DSTableAdapters.LOPTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcKhoa = new DevExpress.XtraGrid.GridControl();
            this.gvKhoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.gvLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelKhoaLop = new DevExpress.XtraEditors.GroupControl();
            this.tbMaKhoa_Lop = new System.Windows.Forms.TextBox();
            this.tbTenLop = new System.Windows.Forms.TextBox();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.tbMaCS = new System.Windows.Forms.TextBox();
            this.tbTenKhoa = new System.Windows.Forms.TextBox();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new THITN.DSTableAdapters.SINHVIENTableAdapter();
            mAKHLabel1 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelKhoaLop)).BeginInit();
            this.panelKhoaLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(1189, 160);
            mAKHLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(79, 21);
            mAKHLabel1.TabIndex = 23;
            mAKHLabel1.Text = "Mã khoa:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(580, 162);
            tENLOPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(72, 21);
            tENLOPLabel.TabIndex = 21;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(149, 162);
            mALOPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(67, 21);
            mALOPLabel.TabIndex = 19;
            mALOPLabel.Text = "Mã lớp:";
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(1189, 70);
            mACSLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(90, 21);
            mACSLabel.TabIndex = 17;
            mACSLabel.Text = "Mã cơ sở: ";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(561, 76);
            tENKHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(84, 21);
            tENKHLabel.TabIndex = 15;
            tENKHLabel.Text = "Tên khoa:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(130, 74);
            mAKHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(79, 21);
            mAKHLabel.TabIndex = 13;
            mAKHLabel.Text = "Mã khoa:";
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
            this.barButtonItem1,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnHuy,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnThoat,
            this.btnThem,
            this.btnThemKhoa,
            this.btnThemLop});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 8;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemKhoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemLop)});
            this.btnThem.Name = "btnThem";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Caption = "Khoa";
            this.btnThemKhoa.Id = 9;
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKhoa_ItemClick);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Caption = "Lớp";
            this.btnThemLop.Id = 10;
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLop_ItemClick);
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
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1325, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1035);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1325, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1325, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 984);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Thêm";
            this.barSubItem1.Id = 0;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.Name = "barSubItem1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbCoSo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 51);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1325, 135);
            this.groupControl1.TabIndex = 5;
            // 
            // cbCoSo
            // 
            this.cbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoSo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(226, 65);
            this.cbCoSo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(373, 29);
            this.cbCoSo.TabIndex = 1;
            this.cbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbCoSo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHOATableAdapter = this.kHOATableAdapter;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcKhoa);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 186);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1325, 281);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Khoa";
            // 
            // gcKhoa
            // 
            this.gcKhoa.DataSource = this.bdsKhoa;
            this.gcKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKhoa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcKhoa.Location = new System.Drawing.Point(2, 28);
            this.gcKhoa.MainView = this.gvKhoa;
            this.gcKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.gcKhoa.MenuManager = this.barManager1;
            this.gcKhoa.Name = "gcKhoa";
            this.gcKhoa.Size = new System.Drawing.Size(1321, 251);
            this.gcKhoa.TabIndex = 0;
            this.gcKhoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhoa});
            // 
            // gvKhoa
            // 
            this.gvKhoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gvKhoa.DetailHeight = 437;
            this.gvKhoa.GridControl = this.gcKhoa;
            this.gvKhoa.Name = "gvKhoa";
            this.gvKhoa.OptionsBehavior.Editable = false;
            // 
            // colMAKH
            // 
            this.colMAKH.Caption = "Mã khoa";
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 31;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            this.colMAKH.Width = 117;
            // 
            // colTENKH
            // 
            this.colTENKH.Caption = "Tên khoa";
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.MinWidth = 31;
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            this.colTENKH.Width = 117;
            // 
            // colMACS
            // 
            this.colMACS.Caption = "Mã cơ sở";
            this.colMACS.FieldName = "MACS";
            this.colMACS.MinWidth = 31;
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            this.colMACS.Width = 117;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gcLop);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 467);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1325, 281);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = "Lớp";
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcLop.Location = new System.Drawing.Point(2, 28);
            this.gcLop.MainView = this.gvLop;
            this.gcLop.Margin = new System.Windows.Forms.Padding(5);
            this.gcLop.MenuManager = this.barManager1;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1321, 251);
            this.gcLop.TabIndex = 0;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLop});
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "FK_LOP_KHOA";
            this.bdsLop.DataSource = this.bdsKhoa;
            // 
            // gvLop
            // 
            this.gvLop.DetailHeight = 437;
            this.gvLop.GridControl = this.gcLop;
            this.gvLop.Name = "gvLop";
            this.gvLop.OptionsBehavior.Editable = false;
            // 
            // panelKhoaLop
            // 
            this.panelKhoaLop.Controls.Add(this.tbMaKhoa_Lop);
            this.panelKhoaLop.Controls.Add(this.tbTenLop);
            this.panelKhoaLop.Controls.Add(this.tbMaLop);
            this.panelKhoaLop.Controls.Add(this.tbMaCS);
            this.panelKhoaLop.Controls.Add(this.tbTenKhoa);
            this.panelKhoaLop.Controls.Add(this.tbMaKhoa);
            this.panelKhoaLop.Controls.Add(mAKHLabel1);
            this.panelKhoaLop.Controls.Add(tENLOPLabel);
            this.panelKhoaLop.Controls.Add(mALOPLabel);
            this.panelKhoaLop.Controls.Add(mACSLabel);
            this.panelKhoaLop.Controls.Add(tENKHLabel);
            this.panelKhoaLop.Controls.Add(mAKHLabel);
            this.panelKhoaLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKhoaLop.Location = new System.Drawing.Point(0, 748);
            this.panelKhoaLop.Margin = new System.Windows.Forms.Padding(5);
            this.panelKhoaLop.Name = "panelKhoaLop";
            this.panelKhoaLop.Size = new System.Drawing.Size(1325, 287);
            this.panelKhoaLop.TabIndex = 11;
            // 
            // tbMaKhoa_Lop
            // 
            this.tbMaKhoa_Lop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MAKH", true));
            this.tbMaKhoa_Lop.Location = new System.Drawing.Point(1339, 155);
            this.tbMaKhoa_Lop.Margin = new System.Windows.Forms.Padding(5);
            this.tbMaKhoa_Lop.Name = "tbMaKhoa_Lop";
            this.tbMaKhoa_Lop.Size = new System.Drawing.Size(204, 28);
            this.tbMaKhoa_Lop.TabIndex = 30;
            // 
            // tbTenLop
            // 
            this.tbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.tbTenLop.Location = new System.Drawing.Point(725, 155);
            this.tbTenLop.Margin = new System.Windows.Forms.Padding(5);
            this.tbTenLop.Name = "tbTenLop";
            this.tbTenLop.Size = new System.Drawing.Size(405, 28);
            this.tbTenLop.TabIndex = 29;
            // 
            // tbMaLop
            // 
            this.tbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.tbMaLop.Location = new System.Drawing.Point(285, 155);
            this.tbMaLop.Margin = new System.Windows.Forms.Padding(5);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(216, 28);
            this.tbMaLop.TabIndex = 28;
            // 
            // tbMaCS
            // 
            this.tbMaCS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MACS", true));
            this.tbMaCS.Location = new System.Drawing.Point(1339, 65);
            this.tbMaCS.Margin = new System.Windows.Forms.Padding(5);
            this.tbMaCS.Name = "tbMaCS";
            this.tbMaCS.Size = new System.Drawing.Size(204, 28);
            this.tbMaCS.TabIndex = 27;
            // 
            // tbTenKhoa
            // 
            this.tbTenKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "TENKH", true));
            this.tbTenKhoa.Location = new System.Drawing.Point(725, 74);
            this.tbTenKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.tbTenKhoa.Name = "tbTenKhoa";
            this.tbTenKhoa.Size = new System.Drawing.Size(405, 28);
            this.tbTenKhoa.TabIndex = 26;
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKhoa, "MAKH", true));
            this.tbMaKhoa.Location = new System.Drawing.Point(285, 72);
            this.tbMaKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.Size = new System.Drawing.Size(216, 28);
            this.tbMaKhoa.TabIndex = 25;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmKhoaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1055);
            this.Controls.Add(this.panelKhoaLop);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoaLop";
            this.Text = "frmKhoaLop";
            this.Load += new System.EventHandler(this.frmKhoaLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelKhoaLop)).EndInit();
            this.panelKhoaLop.ResumeLayout(false);
            this.panelKhoaLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbCoSo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DSTableAdapters.KHOATableAdapter kHOATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.GroupControl panelKhoaLop;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcLop;
        private System.Windows.Forms.BindingSource bdsLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLop;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhoa;
        private DevExpress.XtraBars.BarSubItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnThemKhoa;
        private DevExpress.XtraBars.BarButtonItem btnThemLop;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private System.Windows.Forms.TextBox tbMaKhoa_Lop;
        private System.Windows.Forms.TextBox tbTenLop;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.TextBox tbMaCS;
        private System.Windows.Forms.TextBox tbTenKhoa;
        private System.Windows.Forms.TextBox tbMaKhoa;
    }
}