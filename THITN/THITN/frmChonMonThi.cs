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
    public partial class frmChonMonThi : Form
    {
        public frmChonMonThi()
        {
            InitializeComponent();
        }

        private void frmChonMonThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            txtMaSV.Text = Program.username;
            txtHoTen.Text = Program.mHoten;
            txtNgaySinh.Text = Program.ngaySinhSV;
            txtDiaChi.Text = Program.diaChiSV;
            txtTenLop.Text = Program.tenLopSV;



            // TODO: This line of code loads data into the 'dS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

            if (Program.mGroup == "SINHVIEN")
            {
                gIAOVIEN_DANGKYBindingSource.Filter = "NGAYTHI = '" + DateTime.Now.ToShortDateString() + "'AND MALOP = '" + Program.maLop + "'";
            }
        }

        private void btnBatDauThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.maMH = gvGV_DK.GetRowCellValue(gvGV_DK.FocusedRowHandle, "MAMH").ToString();
            Program.trinhDo = gvGV_DK.GetRowCellValue(gvGV_DK.FocusedRowHandle, "TRINHDO").ToString();
            Program.soCau = gvGV_DK.GetRowCellValue(gvGV_DK.FocusedRowHandle, "SOCAUTHI").ToString();
            Program.ngayThi = gvGV_DK.GetRowCellValue(gvGV_DK.FocusedRowHandle, "NGAYTHI").ToString();
            Program.thoiGian = Int32.Parse(gvGV_DK.GetRowCellValue(gvGV_DK.FocusedRowHandle, "THOIGIAN").ToString());
            Program.lanThi = Int32.Parse(gvGV_DK.GetRowCellValue(gvGV_DK.FocusedRowHandle, "LAN").ToString());

            string strLenh1 = "EXEC dbo.SP_TIMKIEM_TENMH_THEOTEN '" + Program.maMH + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            Program.tenMH = Program.myReader.GetString(0);
            Program.myReader.Close();
            Program.conn.Close();

            string strLenh = "EXEC dbo.SP_KIEMTRA_SINHVIEN_THIROI '" + Program.maMH + "', '" + Program.username + "' , " + Program.lanThi;
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int kq2 = int.Parse(Program.myReader[0].ToString());
            Program.myReader.Close();
            Program.conn.Close();

            if (kq2 == 1)
            {
                MessageBox.Show("Sinh Viên đã thi lớp này, lần này rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmThi f = new frmThi();
            f.Show();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
