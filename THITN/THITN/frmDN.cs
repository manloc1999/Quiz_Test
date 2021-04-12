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
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }


        private void frmDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPM.v_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dsPM.v_DS_PHANMANH);

            string chuoiketnoi = "Data Source=DESKTOP-3T5MH63\\SERVER;Initial Catalog=TN_CSDLPT;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM v_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cbCS.DataSource = dt;
            cbCS.DisplayMember = "TENCS";
            cbCS.ValueMember = "TENSERVER";
            cbCS.SelectedIndex = 0;
            inpMatKhau.Enabled = true;
        }


        private void cbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbCS.SelectedValue.ToString();
            }
            catch (Exception)
            {
            };
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.mCoso = cbCS.SelectedIndex;
            string StrLenh = "";
            if (rbSinhVien.Checked)
            {
                Program.username = inpTaiKhoan.Text;
                Program.mlogin = "STUDENT";
                Program.password = "123";
                if (Program.KetNoi() == 0) return;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;


                StrLenh = "EXEC dbo.SP_DANGNHAPSINHVIEN '" + Program.mloginDN + "', '" + Program.username + "'";
            }

            if (inpTaiKhoan.Text.Trim() == null)
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }

            else if (rbGiangVien.Checked)
            {
                Program.mlogin = inpTaiKhoan.Text;
                Program.password = inpMatKhau.Text;
                if (Program.KetNoi() == 0) return;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                StrLenh = "EXEC dbo.SP_THONGTINDANGNHAP '" + Program.mlogin + "'";
            }
            if (inpMatKhau.Text.Trim() == null)
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader = Program.ExecSqlDataReader(StrLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read(); // đọc 1 dòng

            if (rbSinhVien.Checked)
            {
                if (Program.myReader.GetString(1).Equals("NULL"))
                {
                    MessageBox.Show("Đăng nhập thất bại\n Bạn xem lại tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
            else if (rbGiangVien.Checked)
            {
                if (Program.myReader.GetString(2).Equals("SINHVIEN"))
                {
                    MessageBox.Show("Đăng nhập thất bại\n Bạn xem lại tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }

            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            if (Program.mGroup.Equals("SINHVIEN"))
            {
                string strLenh1 = "EXEC SP_THONGTIN_SINHVIEN '" + Program.username + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh1);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                inpMatKhau.Enabled = false;

                Program.maLop = Program.myReader.GetString(0);
                Program.tenLopSV = Program.myReader.GetString(1);
                Program.mHoten = Program.myReader.GetString(2);
                Program.diaChiSV = Program.myReader.GetString(3);
                Program.ngaySinhSV = Program.myReader.GetString(4);

                Program.myReader.Close();
                Program.conn.Close();


                frmChonMonThi form = new frmChonMonThi();
                //               form.hienThiMenu();
                form.ShowDialog();

                //Program.frmDN.Hide();
            }
            else
            {
                Program.isSinhVien = false;
                frmMain form = new frmMain();
                form.hienThiMenu();
                form.ShowDialog();
                //Program.frmDN.Hide();
            }

            rbGiangVien.Checked = false;
            rbSinhVien.Checked = false;
            inpTaiKhoan.Text = "";
            inpMatKhau.Text = "";
        }

        private void rbGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            inpMatKhau.Enabled = true;
        }

        private void rbSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            inpMatKhau.Enabled = false;
        }
    }
}
