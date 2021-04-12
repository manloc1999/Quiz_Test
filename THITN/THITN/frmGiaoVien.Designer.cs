
namespace THITN
{
    partial class frmGiaoVien
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label mAKHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcTop = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.gc1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.gIAOVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new THITN.DS();
            this.txtHocVi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.gIAOVIENTableAdapter = new THITN.DSTableAdapters.GIAOVIENTableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            this.gvGiaoVien = new DevExpress.XtraGrid.GridControl();
            this.gv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            mAKHLabel1 = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTop)).BeginInit();
            this.gcTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).BeginInit();
            this.gc1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(601, 48);
            mAKHLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(50, 21);
            mAKHLabel1.TabIndex = 0;
            mAKHLabel1.Text = "Khoa";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(88, 63);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(85, 21);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MÃ GV : ";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(88, 122);
            hOLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(51, 21);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HỌ : ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(88, 185);
            tENLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(65, 21);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TÊN :  ";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Location = new System.Drawing.Point(775, 61);
            hOCVILabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(93, 21);
            hOCVILabel.TabIndex = 6;
            hOCVILabel.Text = "ĐỊA CHỈ : ";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(783, 143);
            mAKHLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(84, 21);
            mAKHLabel.TabIndex = 8;
            mAKHLabel.Text = "MÃ KH : ";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnRefresh,
            this.btnHuy,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 1;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
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
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục Hồi";
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1381, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 794);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1381, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 743);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1381, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 743);
            // 
            // gcTop
            // 
            this.gcTop.Controls.Add(this.label1);
            this.gcTop.Controls.Add(this.cmbCoSo);
            this.gcTop.Controls.Add(mAKHLabel1);
            this.gcTop.Controls.Add(this.cmbMaKhoa);
            this.gcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTop.Location = new System.Drawing.Point(0, 51);
            this.gcTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gcTop.Name = "gcTop";
            this.gcTop.Size = new System.Drawing.Size(1381, 95);
            this.gcTop.TabIndex = 7;
            this.gcTop.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cơ sở";
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(205, 48);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(232, 28);
            this.cmbCoSo.TabIndex = 10;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(711, 43);
            this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(379, 28);
            this.cmbMaKhoa.TabIndex = 9;
            this.cmbMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbMaKhoa_SelectedIndexChanged);
            // 
            // gc1
            // 
            this.gc1.Controls.Add(mAKHLabel);
            this.gc1.Controls.Add(this.txtMaKH);
            this.gc1.Controls.Add(hOCVILabel);
            this.gc1.Controls.Add(this.txtHocVi);
            this.gc1.Controls.Add(tENLabel);
            this.gc1.Controls.Add(this.txtTen);
            this.gc1.Controls.Add(hOLabel);
            this.gc1.Controls.Add(this.txtHo);
            this.gc1.Controls.Add(mAGVLabel);
            this.gc1.Controls.Add(this.txtMaGV);
            this.gc1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc1.Location = new System.Drawing.Point(0, 510);
            this.gc1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gc1.Name = "gc1";
            this.gc1.Size = new System.Drawing.Size(1381, 284);
            this.gc1.TabIndex = 12;
            this.gc1.Text = "Thông tin chi tiết";
            // 
            // txtMaKH
            // 
            this.txtMaKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAKH", true));
            this.txtMaKH.Location = new System.Drawing.Point(930, 137);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(406, 28);
            this.txtMaKH.TabIndex = 9;
            // 
            // gIAOVIENBindingSource
            // 
            this.gIAOVIENBindingSource.DataMember = "GIAOVIEN";
            this.gIAOVIENBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtHocVi
            // 
            this.txtHocVi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "HOCVI", true));
            this.txtHocVi.Location = new System.Drawing.Point(930, 56);
            this.txtHocVi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHocVi.Name = "txtHocVi";
            this.txtHocVi.Size = new System.Drawing.Size(406, 28);
            this.txtHocVi.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(235, 175);
            this.txtTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(428, 28);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(235, 117);
            this.txtHo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(428, 28);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaGV
            // 
            this.txtMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIENBindingSource, "MAGV", true));
            this.txtMaGV.Location = new System.Drawing.Point(235, 57);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(268, 28);
            this.txtMaGV.TabIndex = 1;
            // 
            // gIAOVIENTableAdapter
            // 
            this.gIAOVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.gIAOVIENTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gvGiaoVien
            // 
            this.gvGiaoVien.DataSource = this.gIAOVIENBindingSource;
            this.gvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvGiaoVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gvGiaoVien.Location = new System.Drawing.Point(0, 146);
            this.gvGiaoVien.MainView = this.gv;
            this.gvGiaoVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gvGiaoVien.MenuManager = this.barManager1;
            this.gvGiaoVien.Name = "gvGiaoVien";
            this.gvGiaoVien.Size = new System.Drawing.Size(1381, 364);
            this.gvGiaoVien.TabIndex = 13;
            this.gvGiaoVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv});
            // 
            // gv
            // 
            this.gv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colHOCVI,
            this.colMAKH});
            this.gv.DetailHeight = 437;
            this.gv.GridControl = this.gvGiaoVien;
            this.gv.Name = "gv";
            this.gv.OptionsBehavior.Editable = false;
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
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 31;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 117;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 31;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 117;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.MinWidth = 31;
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 3;
            this.colHOCVI.Width = 117;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 31;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 4;
            this.colMAKH.Width = 117;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1381, 814);
            this.Controls.Add(this.gvGiaoVien);
            this.Controls.Add(this.gc1);
            this.Controls.Add(this.gcTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTop)).EndInit();
            this.gcTop.ResumeLayout(false);
            this.gcTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc1)).EndInit();
            this.gc1.ResumeLayout(false);
            this.gc1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource gIAOVIENBindingSource;
        private DS dS;
        private DevExpress.XtraEditors.GroupControl gc1;
        private DevExpress.XtraEditors.GroupControl gcTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private DSTableAdapters.GIAOVIENTableAdapter gIAOVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraGrid.GridControl gvGiaoVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gv;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHocVi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtMaGV;
    }
}