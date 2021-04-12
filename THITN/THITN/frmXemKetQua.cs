using DevExpress.XtraReports.UI;
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
    public partial class frmXemKetQua : Form
    {
        int maBD = 0;
        string maLop = "";
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
          

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");


            cmbCoSo.DataSource = Program.bds_dspm;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoso;

            cmbMaSV.Text = "";

            cmbTenMH.SelectedIndex = 0;

           

            if (Program.mGroup == "SINHVIEN")
            {
                cmbHoTen.Items.Add(Program.mHoten);
                cmbTenLop.Items.Add(Program.tenLopSV);
                cmbHoTen.Enabled = false;
                cmbMaSV.SelectedValue = Program.username;
                cmbMaSV.Enabled = false;
                cmbTenMH.Enabled = false;
                cmbLan.Enabled = false;
                labelTrinhDo.Visible = false;
                labelCoSo.Visible = false;
                cmbTrinhDo.Visible = false;
                cmbCoSo.Visible = false;
                cmbTenLop.Enabled = false;
                cmbTenLop.Text = Program.maLop;
                cmbTenMH.Text = Program.tenMH;
                cmbLan.Text = Program.lanThi.ToString();


            }
            else if (Program.mGroup == "COSO" || Program.mGroup == "GIANGVIEN")
            {
                cmbCoSo.Enabled = false;
            }

            gcXemKetQua.Enabled = false;
            btnIn.Enabled = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maSV = "";
            if (Program.mGroup == "SINHVIEN")
            {
                maSV = Program.username;
            }
            else
            {
                maSV = cmbMaSV.SelectedValue.ToString();
            }

            string strLenh = "EXEC SP_KIEMTRA_SINHVIEN_THIROI '" + cmbTenMH.SelectedValue.ToString() + "', '" + maSV + "',  " + cmbLan.SelectedItem.ToString();
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
            if (kq == 0)
            {
                MessageBox.Show("Sinh viên chưa thi môn này lần " + cmbLan.SelectedItem.ToString() + "\nVui lòng chọn lại môn hoặc lần thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Program.myReader.Close();
                cmbTenMH.Focus();
                return;
            }
            maBD = Int32.Parse(Program.myReader.GetInt32(1).ToString());
            Program.myReader.Close();

            if (Program.mGroup != "SINHVIEN")
            {
                string lenh2 = "EXEC SP_KIEMTRA_TRINHDO '" + cmbTenMH.SelectedValue.ToString() + "', '" + maLop + "' , " + cmbLan.SelectedItem.ToString() + " , '" + cmbTrinhDo.SelectedItem.ToString() + "'";
                Program.myReader = Program.ExecSqlDataReader(lenh2);
                Program.myReader.Read();
                int result2 = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                Program.myReader.Close();

                if (result2 == 0)
                {
                    MessageBox.Show("Trình độ không đúng. Xin chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    cmbTrinhDo.Focus();
                    return;
                }
            }

            this.sP_XEM_KETQUATableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_XEM_KETQUATableAdapter.Fill(this.dS.SP_XEM_KETQUA, maBD);

            string strLenh3 = "EXEC SP_XEM_KETQUA '" + maBD + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh3);
            Program.myReader.Read();
            Program.myReader.Close();
            Program.conn.Close();
            gcXemKetQua.Enabled = true;
            btnXem.Enabled = false;

            cmbTenLop.Enabled = false;
            cmbTenMH.Enabled = false;
            cmbCoSo.Enabled = false;
            cmbLan.Enabled = false;
            cmbMaSV.Enabled = false;
            cmbTrinhDo.Enabled = false;

            btnIn.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string strLenh1 = "EXEC SP_THONGTIN_XEMKQ'" + maBD + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            Program.myReader.Read();
            string ngayThi = Program.myReader.GetDateTime(0).ToString();
            string lan = Program.myReader.GetInt16(1).ToString(); //vi smallint
            string[] str = ngayThi.Split(' ');
            Program.myReader.Close();
            XtraReport_XemKQ xrpt = new XtraReport_XemKQ(maBD);
            xrpt.lbLop.Text = maLop;

            if (Program.mGroup != "SINHVIEN")
            {
                xrpt.lbHoTen.Text = cmbHoTen.Text;
            }
            else
            {
                xrpt.lbHoTen.Text = Program.mHoten;
            }

            xrpt.lbMonThi.Text = cmbTenMH.Text;
            xrpt.lbNgayThi.Text = str[0];
            xrpt.lbLanThi.Text = lan;
            xrpt.lbLop.Text = cmbTenLop.Text;
            ReportPrintTool print = new ReportPrintTool(xrpt);
            print.ShowPreviewDialog();

            cmbTenLop.Enabled = false;
            cmbTenMH.Enabled = false;
            cmbCoSo.Enabled = false;
            cmbLan.Enabled = false;
            cmbMaSV.Enabled = false;
            cmbTrinhDo.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { };
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
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                }
                catch (Exception ex) { }
            }
        }

        private void cmbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {

      

            if (cmbMaSV.SelectedIndex != -1)
            {
                string strLenh1 = "EXEC SP_THONGTIN_SINHVIEN '" + cmbMaSV.SelectedValue.ToString().Trim() + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh1);
                Program.myReader.Read();

                cmbHoTen.Text = Program.myReader.GetString(2);
                cmbTenLop.Text = Program.myReader.GetString(1);

                maLop = Program.myReader.GetString(0);
                Program.myReader.Close();
                Program.conn.Close();
            }
        }
    }
}
