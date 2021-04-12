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
    public partial class frmGiaoVien : Form
    {
        DataTable dt = new DataTable();
        string maKH = "";

        private PhucHoi phucHoi = new PhucHoi();
        private Boolean isDangThem, isDangSua = false;

        public frmGiaoVien()
        {
            InitializeComponent();
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            

            dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
            cmbMaKhoa.DataSource = dt;
            cmbMaKhoa.DisplayMember = "TENKH";
            cmbMaKhoa.ValueMember = "MAKH";
            cmbMaKhoa.SelectedIndex = 0;

            maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
            this.gIAOVIENBindingSource.Filter = "MAKH = '" + maKH + "'";


            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                cmbMaKhoa.Enabled = true;
                btnThoat.Enabled = true;
                btnRefresh.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                btnPhucHoi.Enabled = false;
            }
            else
            {
                cmbCoSo.Enabled = false;

                btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = false;
            }
               
            gc1.Enabled = false;

            if (gIAOVIENBindingSource.Count == 0)
                btnXoa.Enabled = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCoSo.SelectedValue.ToString();
            if (cmbCoSo.SelectedIndex != Program.mCoso)
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
                MessageBox.Show("Lỗi kết nối tới cơ sở mới!", "Lỗi", MessageBoxButtons.OK);
            else
            {

                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

                dt = Program.ExecSqlDataTable("SELECT MAKH, TENKH FROM KHOA");
                cmbMaKhoa.DataSource = dt;
                cmbMaKhoa.DisplayMember = "TENKH";
                cmbMaKhoa.ValueMember = "MAKH";
                cmbMaKhoa.SelectedIndex = 0;

                maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
                this.gIAOVIENBindingSource.Filter = "MAKH = '" + maKH + "'";

            }
        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            maKH = cmbMaKhoa.SelectedValue.ToString().Trim();
            this.gIAOVIENBindingSource.Filter = "MAKH = '" + maKH + "'";

            btnXoa.Enabled = false;
            if (gIAOVIENBindingSource.Count != 0)
                btnXoa.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIENBindingSource.AddNew();
            txtMaGV.Focus();

            txtMaKH.Text = cmbMaKhoa.SelectedValue.ToString();
            txtMaKH.Enabled = false;

            gc1.Enabled = true;

          
            isDangThem = true;
             
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = true;
            cmbMaKhoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = true;
            phucHoi.Save_OldGV(txtMaGV.Text, txtHo.Text, txtTen.Text, txtHocVi.Text, txtMaKH.Text);
            isDangSua = true;
            txtMaGV.Enabled = false;
            cmbMaKhoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã GV không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtMaGV.Focus();
                return;
            }
            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Họ không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if (txtHocVi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Học vị không được trống!", "Lỗi", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            

            try
            {
                if (isDangThem)
                {
                    string strLenh = "EXEC SP_KIEMTRA_MAGVTONTAI '" + txtMaGV.Text + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                    if (kq == 1)
                    {
                        MessageBox.Show("Mã GV đã tồn tại. Mời nhập mã GV khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Program.myReader.Close();
                        txtMaGV.Focus();
                        return;
                    }
                    Program.myReader.Close();

                    phucHoi.PushStack_ThemGV(txtMaGV.Text);
                    isDangThem = false;
                }
                else if (isDangSua)
                {
                    phucHoi.PushStack_SuaGV(txtMaGV.Text,txtHo.Text,txtTen.Text,txtHocVi.Text,txtMaKH.Text);
                    isDangSua = false;                    
                }
                gIAOVIENBindingSource.EndEdit();
                gIAOVIENBindingSource.ResetCurrentItem();
                this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);

                gc1.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = btnPhucHoi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi giáo viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            cmbMaKhoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            txtMaGV.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maGV = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa giáo viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    phucHoi.PushStack_XoaGV(txtMaGV.Text, txtHo.Text, txtTen.Text, txtHocVi.Text, txtMaKH.Text);

                    maGV = ((DataRowView)gIAOVIENBindingSource[gIAOVIENBindingSource.Position])["MAGV"].ToString();

                    gIAOVIENBindingSource.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.dS.GIAOVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                    gIAOVIENBindingSource.Position = gIAOVIENBindingSource.Find("MAGV", maGV);
                    return;
                }
            }
            if (gIAOVIENBindingSource.Count == 0)
                btnXoa.Enabled = false;

            btnPhucHoi.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable Giao vien
                this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gIAOVIENBindingSource.RemoveCurrent();
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);
            gc1.Enabled = false;


            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            btnPhucHoi.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
