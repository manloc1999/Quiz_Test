namespace THITN
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnBoDe = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapLichThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonMonThi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemKetQua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaLop = new DevExpress.XtraBars.BarButtonItem();
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbThi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnTaoTK,
            this.btnDangXuat,
            this.btnSinhVien,
            this.btnMonHoc,
            this.btnGiaoVien,
            this.btnBoDe,
            this.btnLapLichThi,
            this.btnChonMonThi,
            this.btnXemKetQua,
            this.btnXemBangDiem,
            this.barButtonItem1,
            this.btnKhoaLop});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHeThong,
            this.rbDanhMuc,
            this.rbThi,
            this.rbBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1717, 203);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "Tạo Tài Khoản";
            this.btnTaoTK.Id = 1;
            this.btnTaoTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTK.ImageOptions.SvgImage")));
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Caption = "Sinh viên";
            this.btnSinhVien.Id = 3;
            this.btnSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.Image")));
            this.btnSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.ImageOptions.LargeImage")));
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSinhVien_ItemClick);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 4;
            this.btnMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.Image")));
            this.btnMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.ImageOptions.LargeImage")));
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Caption = "Giáo viên";
            this.btnGiaoVien.Id = 7;
            this.btnGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.ImageOptions.Image")));
            this.btnGiaoVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.ImageOptions.LargeImage")));
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaoVien_ItemClick);
            // 
            // btnBoDe
            // 
            this.btnBoDe.Caption = "Bộ đề";
            this.btnBoDe.Id = 8;
            this.btnBoDe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBoDe.ImageOptions.Image")));
            this.btnBoDe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBoDe.ImageOptions.LargeImage")));
            this.btnBoDe.Name = "btnBoDe";
            this.btnBoDe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBoDe_ItemClick);
            // 
            // btnLapLichThi
            // 
            this.btnLapLichThi.Caption = "Lập Lịch Thi";
            this.btnLapLichThi.Id = 11;
            this.btnLapLichThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapLichThi.ImageOptions.Image")));
            this.btnLapLichThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLapLichThi.ImageOptions.LargeImage")));
            this.btnLapLichThi.Name = "btnLapLichThi";
            this.btnLapLichThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapLichThi_ItemClick);
            // 
            // btnChonMonThi
            // 
            this.btnChonMonThi.Caption = "Chọn Môn Thi";
            this.btnChonMonThi.Id = 13;
            this.btnChonMonThi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChonMonThi.ImageOptions.Image")));
            this.btnChonMonThi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChonMonThi.ImageOptions.LargeImage")));
            this.btnChonMonThi.Name = "btnChonMonThi";
            this.btnChonMonThi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChonMonThi_ItemClick_1);
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Caption = "Xem Kết Quả";
            this.btnXemKetQua.Id = 14;
            this.btnXemKetQua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemKetQua.ImageOptions.Image")));
            this.btnXemKetQua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemKetQua.ImageOptions.LargeImage")));
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemKetQua_ItemClick);
            // 
            // btnXemBangDiem
            // 
            this.btnXemBangDiem.Caption = "Xem Bảng Điểm";
            this.btnXemBangDiem.Id = 15;
            this.btnXemBangDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBangDiem.ImageOptions.Image")));
            this.btnXemBangDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXemBangDiem.ImageOptions.LargeImage")));
            this.btnXemBangDiem.Name = "btnXemBangDiem";
            this.btnXemBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemBangDiem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem Danh Sách Đăng Ký";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnKhoaLop
            // 
            this.btnKhoaLop.Caption = "Khoa Lớp";
            this.btnKhoaLop.Id = 17;
            this.btnKhoaLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoaLop.ImageOptions.Image")));
            this.btnKhoaLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhoaLop.ImageOptions.LargeImage")));
            this.btnKhoaLop.Name = "btnKhoaLop";
            this.btnKhoaLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoaLop_ItemClick);
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbDanhMuc
            // 
            this.rbDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.btn});
            this.rbDanhMuc.Name = "rbDanhMuc";
            this.rbDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGiaoVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSinhVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBoDe);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKhoaLop);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btn
            // 
            this.btn.ItemLinks.Add(this.btnLapLichThi);
            this.btn.Name = "btn";
            // 
            // rbThi
            // 
            this.rbThi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbThi.Name = "rbThi";
            this.rbThi.Text = "Thi";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnChonMonThi, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnXemKetQua);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnXemBangDiem);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 804);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1717, 27);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MAGV
            // 
            this.MAGV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(69, 21);
            this.MAGV.Text = "MAGV:";
            // 
            // HOTEN
            // 
            this.HOTEN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(77, 21);
            this.HOTEN.Text = "HOTEN:";
            // 
            // NHOM
            // 
            this.NHOM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(75, 21);
            this.NHOM.Text = "NHOM: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 831);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MAGV;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnGiaoVien;
        private DevExpress.XtraBars.BarButtonItem btnBoDe;
        private DevExpress.XtraBars.BarButtonItem btnLapLichThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btn;
        private DevExpress.XtraBars.BarButtonItem btnChonMonThi;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbThi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnXemKetQua;
        private DevExpress.XtraBars.BarButtonItem btnXemBangDiem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnKhoaLop;
    }
}

