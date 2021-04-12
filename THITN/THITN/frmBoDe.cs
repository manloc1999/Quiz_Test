using DevExpress.XtraEditors;
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
    public partial class frmBoDe : DevExpress.XtraEditors.XtraForm
    {
        public frmBoDe()
        {
            InitializeComponent();
        }
        bool isDangThem = false;
        bool isDangSua = false;
        PhucHoi phucHoi = new PhucHoi();
        private void frmBoDe_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            cbCS.DataSource = Program.bds_dspm;
            cbCS.DisplayMember = "TENCS";
            cbCS.ValueMember = "TENSERVER";
            cbCS.SelectedIndex = Program.mCoso;


            BindingSource bdsMonHoc = new BindingSource();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MAMH, TENMH FROM MONHOC");
            bdsMonHoc.DataSource = dt;
            cbMaMH.DataSource = bdsMonHoc;
            cbMaMH.DisplayMember = "MAMH";
            cbMaMH.ValueMember = "MAMH";

            cbTrinhDo.Items.Add("A");
            cbTrinhDo.Items.Add("B");
            cbTrinhDo.Items.Add("C");

            cbDapAn.Items.Add("A");
            cbDapAn.Items.Add("B");
            cbDapAn.Items.Add("C");
            cbDapAn.Items.Add("D");

            cbTrinhDo.SelectedIndex = 0;
            cbDapAn.SelectedIndex = 0;

            if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnRefresh.Enabled = true;
                btnThoat.Enabled = true;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                panelBoDe.Enabled = false;
                cbCS.Enabled = false;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnRefresh.Enabled = true;
                btnThoat.Enabled = true;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                panelBoDe.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbTrinhDo.SelectedIndex = 1;
            cbDapAn.SelectedIndex = 1;
            cbTrinhDo.SelectedIndex = 0;
            cbDapAn.SelectedIndex = 0;

            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcBoDe.Enabled = false;
            panelBoDe.Enabled = true;

            isDangThem = true;
            bdsBoDe.AddNew();
            string strLenh = "EXEC SP_TUTANG_BODE";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();
            spinCauHoi.Text = kq.ToString();
            tbMaGV.Text = Program.username;
            tbMaGV.Enabled = false;
            tbNoiDung.Focus();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbNoiDung.Focus();
                return;
            }
            if (tbA.Text.Trim() == "")
            {
                MessageBox.Show("Câu A không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbA.Focus();
                return;
            }
            if (tbB.Text.Trim() == "")
            {
                MessageBox.Show("Câu B không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbB.Focus();
                return;

            }
            if (tbC.Text.Trim() == "")
            {
                MessageBox.Show("Câu C không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbC.Focus();
                return;
            }
            if (tbD.Text.Trim() == "")
            {
                MessageBox.Show("Câu D không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbD.Focus();
                return;
            }
            string strLenh1 = "EXEC SP_KIEMTRA_NOIDUNGBD N'" + tbNoiDung.Text + "', N'" + tbA.Text + "', N'" + tbB.Text + "', N'" + tbC.Text + "', N'" + tbD.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            Program.myReader.Close();
            Program.conn.Close();

            if (kq == 1)
            {
                MessageBox.Show("Nội dung và đáp án của câu hỏi bị trùng. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbNoiDung.Focus();
                return;
            }
            cbTrinhDo.Text = cbTrinhDo.SelectedIndex.ToString();
            cbDapAn.Text = cbDapAn.SelectedIndex.ToString();
            cbMaMH.Text = cbMaMH.SelectedIndex.ToString();
            if (isDangThem)
            {
                phucHoi.PushStack_ThemBD(int.Parse(spinCauHoi.Text));
                isDangThem = false;
            }
            else if (isDangSua)
            {
                phucHoi.PushStack_SuaBD();
                isDangSua = false;
            }
            try
            {
                bdsBoDe.EndEdit();
                bdsBoDe.ResetCurrentItem();
                this.bODETableAdapter.Update(this.dS.BODE);

                panelBoDe.Enabled = false;
                cbMaMH.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;
                btnGhi.Enabled = false;
                gcBoDe.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi bộ đề\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMaGV.Text.Trim() != Program.username)
            {
                MessageBox.Show("Chỉ được sửa câu của mình soạn!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                isDangSua = true;
                phucHoi.Save_OldBD(int.Parse(spinCauHoi.Text), tbMaGV.Text, cbMaMH.SelectedValue.ToString(), cbTrinhDo.Text, tbNoiDung.Text, tbA.Text, tbB.Text, tbC.Text, tbD.Text, cbDapAn.Text);
                panelBoDe.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThoat.Enabled = true;
                btnGhi.Enabled = true;
                btnHuy.Enabled = true;
                btnPhucHoi.Enabled = true;
                btnRefresh.Enabled = false;
                gcBoDe.Enabled = false;
                cbMaMH.Enabled = false;
                spinCauHoi.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn Câu hỏi cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tbMaGV.Text.Trim() != Program.username)
            {
                MessageBox.Show("Chỉ được xóa câu của mình soạn!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsBoDe.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa Câu hỏi này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    try
                    {
                        phucHoi.PushStack_XoaBD(int.Parse(spinCauHoi.Text), tbMaGV.Text, cbMaMH.SelectedValue.ToString(), cbTrinhDo.Text, tbNoiDung.Text, tbA.Text, tbB.Text, tbC.Text, tbD.Text, cbDapAn.Text);
                        bdsBoDe.RemoveCurrent();
                        this.bODETableAdapter.Update(this.dS.BODE);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa Câu hỏi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            if (bdsBoDe.Count == 0)
            {
                btnXoa.Enabled = false;
            }

            gcBoDe.Enabled = true;
            panelBoDe.Enabled = false;
            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBoDe.RemoveCurrent();
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            panelBoDe.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            gcBoDe.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ketQua = phucHoi.PopStack();
            if (ketQua.Equals("success"))
            {
                //update lại dataTable sinh viên
                this.bODETableAdapter.Fill(this.dS.BODE);
                MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}