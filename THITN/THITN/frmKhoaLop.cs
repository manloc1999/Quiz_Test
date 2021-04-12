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
    public partial class frmKhoaLop : Form
    {
        bool isThemKhoa = false;
        bool isThemLop = false;
        bool isDangThem = false;
        bool isDangSua = false;
        string statusKhoa = "";
        string statusLop = "";
        PhucHoi phucHoi = new PhucHoi();
        BindingSource bdsCoSo = new BindingSource();
        public frmKhoaLop()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmKhoaLop_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            cbCoSo.DataSource = Program.bds_dspm;
            cbCoSo.DisplayMember = "TENCS";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoso;

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MACS, TENCS FROM COSO");
            bdsCoSo.DataSource = dt;
            tbMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();

            if (Program.mGroup == "GIANGVIEN")
            {
                cbCoSo.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                panelKhoaLop.Enabled = false;
            }
            else if (Program.mGroup == "TRUONG")
            {
                cbCoSo.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnXoa.Enabled = false;
                btnHuy.Enabled = false;
                panelKhoaLop.Enabled = false;
            }
            else
            {
                cbCoSo.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;
                panelKhoaLop.Enabled = false;
            }
        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cbCoSo.SelectedIndex != Program.mCoso)
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
                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.kHOATableAdapter.Fill(this.dS.KHOA);
                    this.lOPTableAdapter.Fill(this.dS.LOP);


                }
                catch (Exception) { }
            }
        }

        private void btnThemKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isThemKhoa = true;
            isDangThem = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            panelKhoaLop.Enabled = true;
            gcKhoa.Enabled = false;
            gcLop.Enabled = false;
            tbMaCS.Enabled = false;
            tbMaLop.Enabled = false;
            tbTenLop.Enabled = false;
            tbMaKhoa_Lop.Enabled = false;
            bdsKhoa.AddNew();
            tbMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();
            tbMaKhoa.Focus();
            statusKhoa = "Them";
        }

        private void btnThemLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isThemLop = true;
            isDangThem = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            panelKhoaLop.Enabled = true;
            gcKhoa.Enabled = false;
            gcLop.Enabled = false;
            tbMaCS.Enabled = false;
            tbMaKhoa.Enabled = false;
            tbTenKhoa.Enabled = false;
            tbMaKhoa_Lop.Enabled = false;
            bdsLop.AddNew();
            tbMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();
            tbMaKhoa_Lop.Text = tbMaKhoa.Text;
            tbMaLop.Focus();
            statusLop = "Them";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvKhoa.IsFocusedView)
            {
                isThemKhoa = true;
                isDangSua = true;
                phucHoi.Save_OldKhoa(tbMaKhoa.Text, tbTenKhoa.Text, tbMaCS.Text);
                panelKhoaLop.Enabled = true;
                tbMaKhoa.Enabled = false;
                gcKhoa.Enabled = false;
                gcLop.Enabled = false;
                tbTenKhoa.Focus();
                tbMaCS.Enabled = false;
                btnThem.Enabled = false;
                tbMaKhoa_Lop.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
                statusKhoa = "Sua";

                tbMaLop.Enabled = tbTenLop.Enabled = tbMaKhoa_Lop.Enabled = false;
            }
            else if (gvLop.IsFocusedView)
            {
                isThemLop = true;
                isDangSua = true;
                phucHoi.Save_OldLop(tbMaLop.Text, tbTenLop.Text, tbMaKhoa_Lop.Text);
                panelKhoaLop.Enabled = true;
                tbMaLop.Enabled = false;
                gcKhoa.Enabled = false;
                gcLop.Enabled = false;
                tbTenLop.Focus();
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
                statusLop = "Sua";

                tbMaKhoa.Enabled = tbTenKhoa.Enabled = tbMaCS.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để cập nhật!\n", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            panelKhoaLop.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvKhoa.IsFocusedView)
            {
                String maKH = "";
                if (bdsKhoa.Count == 0)
                {
                    MessageBox.Show("Không có khoa nào để xóa!\n", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (bdsLop.Count > 0)
                {
                    MessageBox.Show("Khoa đã có lớp nên không thể xóa!\n", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        phucHoi.PushStack_XoaKhoa(tbMaKhoa.Text, tbTenKhoa.Text, tbMaCS.Text);
                        maKH = ((DataRowView)bdsKhoa[bdsKhoa.Position])["MAKH"].ToString();
                        bdsKhoa.RemoveCurrent();
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Update(this.dS.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa khoa. Hãy xóa lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.kHOATableAdapter.Fill(this.dS.KHOA);
                        bdsKhoa.Position = bdsKhoa.Find("MAKH", maKH);
                        return;
                    }
                }
            }
            else if (gvLop.IsFocusedView)
            {
                String maLop = "";
                if (bdsLop.Count == 0)
                {
                    MessageBox.Show("Không có lớp nào để xóa!\n", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (bdsSinhVien.Count > 0)
                {
                    MessageBox.Show("Lớp đã có sinh viên nên không thể xóa!\n", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        phucHoi.PushStack_XoaLop(tbMaLop.Text, tbTenLop.Text, tbMaKhoa_Lop.Text);
                        maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                        bdsLop.RemoveCurrent();
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Update(this.dS.LOP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa lớp. Hãy xóa lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        bdsLop.Position = bdsLop.Find("MALOP", maLop);
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để xóa!\n", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsLop.Count == 0 && bdsKhoa.Count == 0)
                btnXoa.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isThemKhoa)
            {
                if (statusKhoa.Equals("Them"))
                {
                    if (tbMaKhoa.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Mã khoa không được trống!", "Thông báo", MessageBoxButtons.OK);
                        tbMaKhoa.Focus();
                        return;
                    }
                    string strLenh = "EXEC SP_KIEMTRA_MAKHOATONTAI '" + tbMaKhoa.Text + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                    Program.myReader.Close();
                    Program.conn.Close();

                    if (kq == 1)
                    {
                        MessageBox.Show("Mã khoa đã tồn tại. Mời nhập mã khoa khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbMaKhoa.Focus();
                        return;
                    }
                }
                if (tbTenKhoa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên khoa không được trống!", "Thông báo", MessageBoxButtons.OK);
                    tbTenKhoa.Focus();
                    return;
                }
                string strLenh1 = "EXEC SP_KIEMTRA_TENKHOATONTAI '" + tbTenKhoa.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh1);
                Program.myReader.Read();
                int kq1 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                Program.myReader.Close();
                Program.conn.Close();

                if (kq1 == 1)
                {
                    MessageBox.Show("Tên khoa đã tồn tại. Mời nhập tên khoa khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbTenKhoa.Focus();
                    return;
                }
                tbMaCS.Text = ((DataRowView)bdsCoSo[bdsCoSo.Position])["MACS"].ToString();
                try
                {
                    if (isDangThem)
                    {
                        phucHoi.PushStack_ThemKhoa(tbMaKhoa.Text);
                        isDangThem = false;
                    }
                    else if (isDangSua)
                    {
                        phucHoi.PushStack_SuaKhoa(tbMaKhoa.Text, tbTenKhoa.Text);
                        isDangSua = false;
                    }
                    bdsKhoa.EndEdit();
                    bdsKhoa.ResetCurrentItem();
                    this.kHOATableAdapter.Update(this.dS.KHOA);
                    isThemKhoa = false;
                    tbMaCS.Enabled = true;

                    panelKhoaLop.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    gcKhoa.Enabled = true;
                    gcLop.Enabled = true;
                    statusKhoa = "";

                    tbMaKhoa.Enabled = tbTenKhoa.Enabled = tbMaCS.Enabled = true;
                    tbMaLop.Enabled = tbTenLop.Enabled = tbMaKhoa_Lop.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khoa\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
            if (isThemLop)
            {
                if (statusLop.Equals("Them"))
                {
                    if (tbMaLop.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Mã lớp không được trống!", "Thông báo", MessageBoxButtons.OK);
                        tbMaLop.Focus();
                        return;
                    }
                    string strLenh = "EXEC SP_KIEMTRA_LOP_TONTAI '" + tbMaLop.Text + "'";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                    Program.myReader.Close();
                    Program.conn.Close();

                    if (kq == 1)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại. Mời nhập mã lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbMaLop.Focus();
                        return;
                    }
                }
                if (tbTenLop.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên lớp không được trống!", "Thông báo", MessageBoxButtons.OK);
                    tbTenLop.Focus();
                    return;
                }
                string strLenh1 = "EXEC SP_KIEMTRA_TENLOPTONTAI '" + tbTenLop.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh1);
                Program.myReader.Read();
                int kq1 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                Program.myReader.Close();
                Program.conn.Close();

                if (kq1 == 1)
                {
                    MessageBox.Show("Tên lớp đã tồn tại. Mời nhập tên lớp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbTenLop.Focus();
                    return;
                }
                try
                {
                    if (isDangThem)
                    {
                        phucHoi.PushStack_ThemLop(tbMaLop.Text.Trim());
                        isDangThem = false;
                    }
                    else if (isDangSua)
                    {
                        phucHoi.PushStack_SuaLop(tbMaLop.Text.Trim(), tbTenLop.Text.Trim());
                        isDangSua = false;
                    }
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    isThemLop = false;
                    tbMaKhoa.Enabled = true;

                    panelKhoaLop.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    gcKhoa.Enabled = true;
                    gcLop.Enabled = true;
                    statusLop = "";

                    tbMaKhoa.Enabled = tbTenKhoa.Enabled = tbMaCS.Enabled = true;
                    tbMaLop.Enabled = tbTenLop.Enabled = tbMaKhoa_Lop.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khoa\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable sinh viên
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                this.lOPTableAdapter.Fill(this.dS.LOP);
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isThemKhoa || gvKhoa.IsFocusedView)
            {
                bdsKhoa.RemoveCurrent();
            }
            else if (isThemLop || gvLop.IsFocusedView)
            {
                bdsLop.RemoveCurrent();
            }

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            panelKhoaLop.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            gcKhoa.Enabled = true;
            gcLop.Enabled = true;

            tbMaKhoa.Enabled = tbTenKhoa.Enabled = tbMaCS.Enabled = true;
            tbMaLop.Enabled = tbTenLop.Enabled = tbMaKhoa_Lop.Enabled = true;
            statusKhoa = "";
            statusLop = "";
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}
