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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load_1(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dsGV.V_DSGVChuaCoTaiKhoan' table. You can move, or remove it, as needed.
            this.v_DSGVChuaCoTaiKhoanTableAdapter.Fill(this.dsGV.V_DSGVChuaCoTaiKhoan);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            if (Program.mGroup.Trim() == "GIANGVIEN")
            {
                MessageBox.Show("BẠN KHÔNG CÓ QUYỀN NÀY", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                groupDangNhap.Enabled = false;
                return;
            }

            if (Program.mGroup.Trim() == "TRUONG")
            {
                cbNhom.Items.Add("TRUONG");
                cbNhom.Enabled = false;
            }
            else if (Program.mGroup.Trim() == "COSO")
            {
                cbNhom.Items.Add("GIANGVIEN");
                cbNhom.Items.Add("COSO");
                cbNhom.Enabled = true;
            }
            cbNhom.SelectedIndex = 0;
            DataTable dt = new DataTable();

            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSGVChuaCoTaiKhoan");
            cbTenGV.DataSource = dt;
            cbTenGV.DisplayMember = "HOTEN"; //ten cot muon hien len
            cbTenGV.ValueMember = "MAGV"; //gia tri muon hien len

            if (cbTenGV.SelectedValue == null)
            {
                MessageBox.Show("Không có giáo viên nào chưa có tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                cbTenGV.SelectedIndex = 0;
            }
        }

        private void btnTaoTK_Click_1(object sender, EventArgs e)
        {
            if (tbTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbTaiKhoan.Focus();
                return;
            }
            if (tbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbMatKhau.Focus();
                return;
            }

            try
            {
                string strLenh = "EXEC SP_TAO_TAIKHOAN '" + tbTaiKhoan.Text + "', '" + tbMatKhau.Text + "', '" + cbTenGV.SelectedValue.ToString() + "' , '" + cbNhom.SelectedItem.ToString() + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                Program.myReader.Close();
                Program.conn.Close();
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Tạo tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
