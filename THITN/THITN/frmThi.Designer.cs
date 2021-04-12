
namespace THITN
{
    partial class frmThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThi));
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTime = new System.Windows.Forms.Label();
            this.rdbDapAn = new DevExpress.XtraEditors.RadioGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNopBai = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKQ = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.rdbCauHoi = new DevExpress.XtraEditors.RadioGroup();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHo = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtMonThi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new THITN.DS();
            this.sP_XEM_KETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_XEM_KETQUATableAdapter = new THITN.DSTableAdapters.SP_XEM_KETQUATableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl1);
            this.panelControl4.Controls.Add(this.panelControl1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 51);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1124, 644);
            this.panelControl4.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblTime);
            this.groupControl1.Controls.Add(this.rdbDapAn);
            this.groupControl1.Controls.Add(this.rdbCauHoi);
            this.groupControl1.Controls.Add(this.lblCauHoi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 127);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1120, 515);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Nội dung";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(446, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 21);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00";
            // 
            // rdbDapAn
            // 
            this.rdbDapAn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rdbDapAn.Location = new System.Drawing.Point(2, 312);
            this.rdbDapAn.MenuManager = this.barManager1;
            this.rdbDapAn.Name = "rdbDapAn";
            this.rdbDapAn.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDapAn.Properties.Appearance.Options.UseFont = true;
            this.rdbDapAn.Size = new System.Drawing.Size(1028, 201);
            this.rdbDapAn.TabIndex = 2;
            this.rdbDapAn.SelectedIndexChanged += new System.EventHandler(this.rdbDapAn_SelectedIndexChanged_1);
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
            this.barStaticItem1,
            this.btnNopBai,
            this.btnXemKQ});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            this.bar2.FloatLocation = new System.Drawing.Point(655, 229);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNopBai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXemKQ, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNopBai
            // 
            this.btnNopBai.Caption = "Nộp Bài";
            this.btnNopBai.Id = 1;
            this.btnNopBai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNopBai.ImageOptions.Image")));
            this.btnNopBai.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNopBai.ImageOptions.LargeImage")));
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Caption = "Xem Kết Quả";
            this.btnXemKQ.Id = 3;
            this.btnXemKQ.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemKQ.ImageOptions.Image")));
            this.btnXemKQ.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemKQ.ImageOptions.LargeImage")));
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemKQ_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Time";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1124, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 695);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1124, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1124, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 644);
            // 
            // rdbCauHoi
            // 
            this.rdbCauHoi.AllowDrop = true;
            this.rdbCauHoi.Dock = System.Windows.Forms.DockStyle.Right;
            this.rdbCauHoi.Location = new System.Drawing.Point(1030, 28);
            this.rdbCauHoi.MenuManager = this.barManager1;
            this.rdbCauHoi.Name = "rdbCauHoi";
            this.rdbCauHoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCauHoi.Properties.Appearance.Options.UseFont = true;
            this.rdbCauHoi.Size = new System.Drawing.Size(88, 485);
            this.rdbCauHoi.TabIndex = 1;
            this.rdbCauHoi.SelectedIndexChanged += new System.EventHandler(this.rdbCauHoi_SelectedIndexChanged_1);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(22, 57);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(77, 25);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Câu 1 :";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtTenLop);
            this.panelControl1.Controls.Add(this.lblMaLop);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.txtNgaySinh);
            this.panelControl1.Controls.Add(this.lblDiaChi);
            this.panelControl1.Controls.Add(this.lblNgaySinh);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.txtMaSV);
            this.panelControl1.Controls.Add(this.lblHo);
            this.panelControl1.Controls.Add(this.lblMSV);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Enabled = false;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1120, 124);
            this.panelControl1.TabIndex = 3;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(719, 12);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(233, 28);
            this.txtTenLop.TabIndex = 34;
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(597, 16);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(84, 21);
            this.lblMaLop.TabIndex = 33;
            this.lblMaLop.Text = "Tên Lớp :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(418, 61);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(238, 28);
            this.txtDiaChi.TabIndex = 32;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(450, 12);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(123, 28);
            this.txtNgaySinh.TabIndex = 31;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(336, 61);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(74, 21);
            this.lblDiaChi.TabIndex = 30;
            this.lblDiaChi.Text = "Địa chỉ :";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(336, 19);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(93, 21);
            this.lblNgaySinh.TabIndex = 29;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 58);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(190, 28);
            this.txtHoTen.TabIndex = 28;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(133, 12);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(182, 28);
            this.txtMaSV.TabIndex = 27;
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHo.Location = new System.Drawing.Point(21, 58);
            this.lblHo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(69, 21);
            this.lblHo.TabIndex = 26;
            this.lblHo.Text = "Họ tên :";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSV.Location = new System.Drawing.Point(12, 15);
            this.lblMSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(113, 21);
            this.lblMSV.TabIndex = 25;
            this.lblMSV.Text = "Mã sinh viên :";
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.DockCol = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.Text = "Status bar";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Tools";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // txtMonThi
            // 
            this.txtMonThi.Location = new System.Drawing.Point(529, 22);
            this.txtMonThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonThi.MenuManager = this.barManager1;
            this.txtMonThi.Name = "txtMonThi";
            this.txtMonThi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonThi.Properties.Appearance.Options.UseFont = true;
            this.txtMonThi.Size = new System.Drawing.Size(266, 26);
            this.txtMonThi.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Môn Thi : ";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_XEM_KETQUABindingSource
            // 
            this.sP_XEM_KETQUABindingSource.DataMember = "SP_XEM_KETQUA";
            this.sP_XEM_KETQUABindingSource.DataSource = this.dS;
            // 
            // sP_XEM_KETQUATableAdapter
            // 
            this.sP_XEM_KETQUATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1124, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonThi);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThi";
            this.Text = "frmThi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDapAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbCauHoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNopBai;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMonThi;
        private DevExpress.XtraBars.BarButtonItem btnXemKQ;
        private System.Windows.Forms.BindingSource sP_XEM_KETQUABindingSource;
        private DS dS;
        private DSTableAdapters.SP_XEM_KETQUATableAdapter sP_XEM_KETQUATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblMSV;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraEditors.RadioGroup rdbDapAn;
        private DevExpress.XtraEditors.RadioGroup rdbCauHoi;
        private System.Windows.Forms.Label lblCauHoi;
    }
}