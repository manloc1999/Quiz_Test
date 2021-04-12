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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPM.v_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.dsPM.v_DS_PHANMANH);
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'DS.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.DS.COSO);
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);


            if (Program.mGroup == "TRUONG" || Program.mGroup == "GIANGVIEN")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                panelMonHoc.Enabled = false;
            }         
            else
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnGhi.Enabled = false;
                btnHuy.Enabled = false;
                panelMonHoc.Enabled = false;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
            btnXoa.Enabled = false;
            panelMonHoc.Enabled = true;
            bdsMonHoc.AddNew();
            tbMaMH.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbMaMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                tbMaMH.Focus();
                return;
            }
            if (tbTenMH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên môn học không được trống!", "Lỗi", MessageBoxButtons.OK);
                tbTenMH.Focus();
                return;
            }
            try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Update(this.DS.MONHOC);

                panelMonHoc.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnHuy.Enabled = false;
                btnGhi.Enabled = false;
                gcMonHoc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.RemoveCurrent();
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
            panelMonHoc.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            gcMonHoc.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maMH = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maMH = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.DS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", maMH);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0)
                btnXoa.Enabled = false;
        }     
    }
}