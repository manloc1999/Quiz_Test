using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmGiaoVienDK : Form
    {
        public static string maMH = "";
        public static string maLop = "";
        public static Boolean isDangThem = false;
        public static Boolean isDangSua = false;
        public frmGiaoVienDK()
        {
            InitializeComponent();
        }

        private void frmGiaoVienDK_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);


            pncGVDK.Enabled = false;
            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbTrinhDo.SelectedIndex = 0;


            cbCS.DataSource = Program.bds_dspm;
            cbCS.DisplayMember = "TENCS";
            cbCS.ValueMember = "TENSERVER";
            cbCS.SelectedIndex = Program.mCoso;
            txtMaGV.Enabled = false;
            if (Program.mGroup == "TRUONG")
            {
                pncGVDK.Enabled = false;
                gcGiaoVienDK.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnRefresh.Enabled = false;
                btnThoat.Enabled = true;
                btnGhi.Enabled = false;
                cbCS.Enabled = true;
            }
            else
            {
                btnGhi.Enabled = false;
                cbCS.Enabled = false;
                pncGVDK.Enabled = false;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gIAOVIEN_DANGKYBindingSource.AddNew();
            txtMaGV.Text = Program.username;
            cmbTenMH.Focus();
            dptNgayThi.EditValue = "";
            cmbTrinhDo.SelectedIndex = 1;


            cmbTrinhDo.SelectedIndex = 0;

            gcGiaoVienDK.Enabled = false;
            pncGVDK.Enabled = true;
            isDangThem = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "SELECT dbo.KIEMTRA_MONHOC_DATHI('" + cmbTenMH.SelectedValue.ToString() + "', " + spinLan.Text.Trim() + ", '" + cmbTenLop.SelectedValue.ToString().Trim() + "') AS DATHI";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            string kt = Program.myReader[0].ToString();
            Program.myReader.Close();
            Program.conn.Close();

            if (kt.Trim() != "")
            {
                MessageBox.Show("Lớp này đã thi, không được sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            pncGVDK.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gcGiaoVienDK.Enabled = false;
            cmbTenLop.Enabled = cmbTenMH.Enabled = cmbTrinhDo.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cmbTenMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã môn học không được trống !", "Lỗi", MessageBoxButtons.OK);
                cmbTenMH.Focus();
                return;
            }
            if (cmbTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã lớp không được trống !", "Lỗi", MessageBoxButtons.OK);
                cmbTenLop.Focus();
                return;
            }
            if (dptNgayThi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ngày thi không được trống !", "Lỗi", MessageBoxButtons.OK);
                dptNgayThi.Focus();
                return;
            }
            if (dptNgayThi.DateTime.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thi không hợp lệ !", "Lỗi", MessageBoxButtons.OK);
                dptNgayThi.Focus();
                return;
            }
            if (spinLan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lần thi không được trống !", "Lỗi", MessageBoxButtons.OK);
                spinLan.Focus();
                return;
            }
            if (spinSoCau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số câu thi không được trống !", "Lỗi", MessageBoxButtons.OK);
                spinSoCau.Focus();
                return;
            }
            else if (spinThoiGian.Value < 15 || spinThoiGian.Value > 60)
            {
                MessageBox.Show("Thời gian thi phải nằm trong khoảng 15 đến 60 phút!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                spinThoiGian.Focus();
                return;
            }

            if (spinThoiGian.Text.Trim().Length == 0)
            {
                MessageBox.Show("Thời gian thi không được trống !", "Lỗi", MessageBoxButtons.OK);
                spinThoiGian.Focus();
                return;
            }
            string sql = "EXEC SP_CHUANBITHI '" + cmbTenMH.SelectedValue.ToString().Trim() + "', '" + cmbTrinhDo.Text.Trim() + "', '" + spinSoCau.Text.Trim() + "'";
            int ketQua = Program.ExecSqlNonQuery(sql);
            if (ketQua == 1)
            {
                return;
            }
            cmbTrinhDo.Text = cmbTrinhDo.SelectedIndex.ToString();

            try
            {
                string sql1 = "";
                sql1 = "EXEC SP_KIEMTRA_GVDK_TONTAI '" + cmbTenMH.SelectedValue.ToString() + "', '" + cmbTenLop.SelectedValue.ToString() + "', '" + spinLan.Text.Trim() + "', '" + dptNgayThi.Text + "'";
                if (Program.ExecSqlNonQuery(sql1) == 1)
                {
                    return;
                }
                gIAOVIEN_DANGKYBindingSource.EndEdit();
                gIAOVIEN_DANGKYBindingSource.ResetCurrentItem();
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                gcGiaoVienDK.Enabled = true;
                pncGVDK.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đăng ký thi\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            string strLenh = "SELECT dbo.KIEMTRA_MONHOC_DATHI('" + cmbTenMH.ValueMember + "', " + spinLan.Text.Trim() + ", '" + cmbTenLop.ValueMember + "') AS DATHI";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            string kt = Program.myReader[0].ToString();
            Program.myReader.Close();
            Program.conn.Close();

            if (kt.Trim() != "")
            {
                MessageBox.Show("Lớp này đã thi, không được sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (gIAOVIEN_DANGKYBindingSource.Count == 0)
            {
                MessageBox.Show("Không có lịch thi để xóa!", "Thông báo", MessageBoxButtons.OK);
                btnXoa.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa lịch thi này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        gIAOVIEN_DANGKYBindingSource.RemoveCurrent();
                        this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIAOVIEN_DANGKYTableAdapter.Update(this.dS.GIAOVIEN_DANGKY);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
                        return;
                    }
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false; //cac quy tac khong duoc thi hanh
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIEN_DANGKYBindingSource.CancelEdit(); //hủy hiệu chỉnh trên hàng
            dS.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);
            pncGVDK.Enabled = false;

            btnGhi.Enabled = false;

            gcGiaoVienDK.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}
