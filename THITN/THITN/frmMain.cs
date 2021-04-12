using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

            if (Program.mGroup == "GIANGVIEN")
            {
                rbHeThong.Visible = true;
                btnTaoTK.Enabled = false;               
                rbDanhMuc.Visible = true;
                rbBaoCao.Visible = false;
                rbThi.Visible = true;
                btnBoDe.Enabled = true;
                btnChonMonThi.Enabled = true;
                btnGiaoVien.Enabled = btnKhoaLop.Enabled = btnLapLichThi.Enabled = btnSinhVien.Enabled = btnMonHoc.Enabled = false;
                
            }
        }

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void dangNhapSV()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                btnBoDe.Enabled = false;
                btnGiaoVien.Enabled = false;
            }
            else btnBoDe.Enabled = true;
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void hienThiMenu()
        {
            MAGV.Text = "Mã GV: " + Program.username;
            HOTEN.Text = "Tên GV: " + Program.mHoten;
            NHOM.Text = "Nhóm: " + Program.mGroup;
            btnTaoTK.Enabled = true;
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Trim().Length == 0 || Program.mGroup.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa đăng nhập!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            Form frmSV = this.CheckExists(typeof(frmSinhVien));
            if (frmSV != null)
                frmSV.Close();
            Form frmGV = this.CheckExists(typeof(frmGiaoVien));
            if (frmGV != null)
                frmGV.Close();
            Form frmMH = this.CheckExists(typeof(frmMonHoc));
            if (frmMH != null)
                frmMH.Close();
            Form frmBD = this.CheckExists(typeof(frmBoDe));
            if (frmBD != null)
                frmBD.Close();
            Form frmCBThi = this.CheckExists(typeof(frmGiaoVienDK));
            if (frmCBThi != null)
                frmCBThi.Close();

            Program.myReader = null;
            Program.username = "";
            Program.mlogin = "";
            Program.password = "";
            Program.mloginDN = "";
            Program.passwordDN = "";
            Program.mGroup = "";
            Program.mHoten = "";
            Program.mCoso = 0;
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
            return;
        }

        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaoVien f = new frmGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBoDe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBoDe));
            if (frm != null) frm.Activate();
            else
            {
                frmBoDe f = new frmBoDe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnLapLichThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoVienDK));
            if (frm != null) frm.Activate();
            else
            {
                frmGiaoVienDK f = new frmGiaoVienDK();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnChonMonThi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmChonMonThi));
            if (frm != null)
                frm.Activate();
            else
            {
                frmChonMonThi f = new frmChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmXemKetQua));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXemKetQua f = new frmXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmXemBangDiem));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXemBangDiem f = new frmXemBangDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm = this.CheckExists(typeof(frmXemDSDK));
            if (frm != null)
                frm.Activate();
            else
            {
                frmXemDSDK f = new frmXemDSDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhoaLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mHoten.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form frm = this.CheckExists(typeof(frmKhoaLop));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKhoaLop f = new frmKhoaLop();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
