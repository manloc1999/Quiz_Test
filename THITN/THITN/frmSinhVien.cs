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

namespace THITN
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        string maLop = "";
        int vitri;
        string statusSV = "";
        string statusLop = "";
        private PhucHoi phucHoi = new PhucHoi();
        private Boolean isDangThem, isDangSua = false;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr; //chay tren tai khaon moi nhat khi dang nhap
            this.lOPTableAdapter.Fill(this.dS.LOP);

            BindingSource bdsLop = new BindingSource();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MALOP, TENLOP FROM LOP");
            bdsLop.DataSource = dt;
            cbMaLop.DataSource = bdsLop;
            cbMaLop.DisplayMember = "MALOP";
            cbMaLop.ValueMember = "MALOP";
            cbMaLop.SelectedIndex = 0;

            cbCS.DataSource = Program.bds_dspm;
            cbCS.DisplayMember = "TENCS";
            cbCS.ValueMember = "TENSERVER";
            cbCS.SelectedIndex = Program.mCoso;


            if (Program.mGroup == "GIANGVIEN")
            {
                cbCS.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                panelSinhVien.Enabled = false;
            }
            else if (Program.mGroup == "TRUONG")
            {
                cbCS.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                panelSinhVien.Enabled = false;
            }
            else
            {
                cbCS.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;
                panelSinhVien.Enabled = false;
            }

        }
        private void cbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCS.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbCS.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cbCS.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);


                }
                catch (Exception) { }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangThem = true;
            vitri = bdsSV.Position;
            panelSinhVien.Enabled = true;
            bdsSV.AddNew();
            dtNgaySinh.EditValue = "";
            gcSinhVien.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnPhucHoi.Enabled = false;
            statusSV = "Them";
            tbMaSV.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isDangSua = true;
            phucHoi.Save_OldSV(tbHo.Text, tbTen.Text, dtNgaySinh.Text, tbDiaChi.Text, cbMaLop.SelectedValue.ToString());
            panelSinhVien.Enabled = true;
            tbMaSV.Enabled = false;
            gcSinhVien.Enabled = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnPhucHoi.Enabled = false;
            statusSV = "Sua";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (statusSV.Equals("Them"))
            {
                if (tbMaSV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                    tbMaSV.Focus();
                    return;
                }
                string strLenh = "EXEC SP_KIEMTRA_SV_TONTAI'" + tbMaSV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                Program.myReader.Close();
                Program.conn.Close();

                if (kq == 1)
                {
                    MessageBox.Show("Mã SV đã tồn tại. Mời nhập mã SV khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbMaSV.Focus();
                    return;
                }
            }
            if (tbHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                tbHo.Focus();
                return;
            }
            if (tbTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên sinh viên không được trống!", "Lỗi", MessageBoxButtons.OK);
                tbTen.Focus();
                return;
            }
            if (dtNgaySinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày sinh không được trống!", "Lỗi", MessageBoxButtons.OK);
                dtNgaySinh.Focus();
                return;
            }
            cbMaLop.Text = cbMaLop.SelectedIndex.ToString();
            try
            {
                if (isDangThem)
                {
                    phucHoi.PushStack_ThemSV(tbMaSV.Text);
                    isDangThem = false;
                }
                else if (isDangSua)
                {
                    phucHoi.PushStack_SuaSV(tbMaSV.Text);
                    isDangSua = false;
                }
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);

                tbMaSV.Enabled = true;

                gcSinhVien.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                btnPhucHoi.Enabled = true;
                panelSinhVien.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 maSV = 0;
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    phucHoi.PushStack_XoaSV(tbMaSV.Text, tbHo.Text, tbTen.Text, dtNgaySinh.Text, tbDiaChi.Text, cbMaLop.SelectedValue.ToString());
                    maSV = int.Parse(((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString());
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", maSV);
                    return;
                }
            }
            if (bdsSV.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable sinh viên
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSV.RemoveCurrent();
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            panelSinhVien.Enabled = false;
            gcSinhVien.Enabled = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            btnPhucHoi.Enabled = true;
        }
    }
}
