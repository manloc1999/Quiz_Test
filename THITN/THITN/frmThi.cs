using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmThi : Form
    {

        Dictionary<int, CauHoi> deThi = new Dictionary<int, CauHoi>();
        BindingSource bdsDethi;

        int phut;
        int giay;
        double diem = 0.0;
        double diemMoiCau = 0.0;
        int IDBD = 0;
        public frmThi()
        {
            InitializeComponent();

            setThoiGian();


            txtMonThi.Text = Program.tenMH;
            txtMaSV.Text = Program.username;
            txtHoTen.Text = Program.mHoten;
            txtNgaySinh.Text = Program.ngaySinhSV;
            txtDiaChi.Text = Program.diaChiSV;
            txtTenLop.Text = Program.tenLopSV;
            txtMonThi.Enabled = false;

            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC SP_THI '" + Program.maMH + "', '" + Program.trinhDo + "', " + Program.soCau + "";

                dt = Program.ExecSqlDataTable(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            bdsDethi = new BindingSource();
            bdsDethi.DataSource = dt;
            for (int i = 1; i <= bdsDethi.Count; i++)
            {
                rdbCauHoi.Properties.Items.Add(new RadioGroupItem(i, "" + i));
                deThi.Add(i, LayCauHoiTuBDS(i - 1));
            }
            rdbCauHoi.SelectedIndex = 0;
            diemMoiCau = 10.0 / Double.Parse(Program.soCau);
            timer.Start();
            btnXemKQ.Enabled = false;
        }
        public void setThoiGian()
        {
            phut = Program.thoiGian - 1;
            giay = 60;
        }

        public void hienThiTG()
        {
            if (giay < 10)
            {
                if (phut > 10)
                    lblTime.Text = phut + ":0" + giay;
                else
                    lblTime.Text = "0" + phut + ":0" + giay;
            }
            else
            {
                if (giay == 60)
                {
                    if (phut > 10)
                        lblTime.Text = phut + ":00";
                    else
                        lblTime.Text = "0" + phut + ":00";
                }
                else
                {
                    if (phut > 10)
                        lblTime.Text = phut + ":" + giay;
                    else
                        lblTime.Text = "0" + phut + ":" + giay;
                }
            }
        }
        public CauHoi LayCauHoiTuBDS(int vitri)
        {
            CauHoi c = new CauHoi();

            c.IDCauHoi = ((DataRowView)bdsDethi[vitri])["CAUHOI"].ToString().Trim();
            c.MaMH = ((DataRowView)bdsDethi[vitri])["MAMH"].ToString().Trim();
            c.MaGV = ((DataRowView)bdsDethi[vitri])["MAGV"].ToString().Trim();
            c.TrinhDo = ((DataRowView)bdsDethi[vitri])["TRINHDO"].ToString().Trim();
            c.NoiDung = ((DataRowView)bdsDethi[vitri])["NOIDUNG"].ToString().Trim();
            c.A = ((DataRowView)bdsDethi[vitri])["A"].ToString().Trim();
            c.B = ((DataRowView)bdsDethi[vitri])["B"].ToString().Trim();
            c.C = ((DataRowView)bdsDethi[vitri])["C"].ToString().Trim();
            c.D = ((DataRowView)bdsDethi[vitri])["D"].ToString().Trim();
            c.DapAn = ((DataRowView)bdsDethi[vitri])["DAP_AN"].ToString().Trim();
            c.DaChon = "X";

            c.Tron();

            return c;
        }

        private void rdbDapAn_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (rdbDapAn.SelectedIndex != -1)
                deThi[rdbCauHoi.SelectedIndex + 1].DaChon = rdbDapAn.EditValue.ToString();
        }

        private void rdbCauHoi_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            rdbDapAn.Properties.Items.Clear();
            lblCauHoi.Text = "Câu " + rdbCauHoi.EditValue.ToString() + ": " + deThi[rdbCauHoi.SelectedIndex + 1].NoiDung;
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("A", "A. " + deThi[rdbCauHoi.SelectedIndex + 1].A));
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("B", "B. " + deThi[rdbCauHoi.SelectedIndex + 1].B));
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("C", "C. " + deThi[rdbCauHoi.SelectedIndex + 1].C));
            rdbDapAn.Properties.Items.Add(new RadioGroupItem("D", "D. " + deThi[rdbCauHoi.SelectedIndex + 1].D));

            switch (deThi[rdbCauHoi.SelectedIndex + 1].DaChon)
            {
                case "A":
                    rdbDapAn.SelectedIndex = 0;
                    break;
                case "B":
                    rdbDapAn.SelectedIndex = 1;
                    break;
                case "C":
                    rdbDapAn.SelectedIndex = 2;
                    break;
                case "D":
                    rdbDapAn.SelectedIndex = 3;
                    break;
                case "null":
                    rdbDapAn.SelectedIndex = -1;
                    break;
            }
        }


        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (phut != 0 && giay != 0)
            {
                if (MessageBox.Show("Chưa hết thời gian, bạn có chắc nộp bài không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tinhDiem();
                    luuVaoBangDiem();
                    timer.Stop();
                    phut = 0;
                    giay = 0;
                    hienThiTG();
                    MessageBox.Show("Điểm của bạn: " + diem, "Điểm", MessageBoxButtons.OK);
                }
                btnNopBai.Enabled = false;
                btnXemKQ.Enabled = true;
            }
        }

        public void tinhDiem()
        {
            foreach (KeyValuePair<int, CauHoi> item in deThi)
            {
                if (item.Value.DaChon == item.Value.DapAn)
                {
                    diem += diemMoiCau;
                }
            }
        }

        public void luuCTBT(int IDBD)
        {
            try
            {
                Program.conn.Open();
                foreach (KeyValuePair<int, CauHoi> item in deThi)
                {
                    String MyCommand = "INSERT INTO CT_BAITHI (IDBD, CAUHOI, DACHON, STT ,NOIDUNG , A, B, C, D, DAPAN) " +
                        "VALUES(@IDBD, @CAUHOI, @DACHON, @STT,  @NOIDUNG, @A, @B, @C, @D, @DAPAN)";
                    SqlCommand adder = new SqlCommand(MyCommand, Program.conn);
                    adder.CommandType = CommandType.Text;
                    adder.Parameters.Add(new SqlParameter("@IDBD", IDBD));
                    adder.Parameters.Add(new SqlParameter("@CAUHOI", item.Value.IDCauHoi));
                    adder.Parameters.Add(new SqlParameter("@DACHON", item.Value.DaChon));
                    adder.Parameters.Add(new SqlParameter("@STT", item.Key));
                    adder.Parameters.Add(new SqlParameter("@NOIDUNG", item.Value.NoiDung));
                    adder.Parameters.Add(new SqlParameter("@A", item.Value.A));
                    adder.Parameters.Add(new SqlParameter("@B", item.Value.B));
                    adder.Parameters.Add(new SqlParameter("@C", item.Value.C));
                    adder.Parameters.Add(new SqlParameter("@D", item.Value.D));
                    adder.Parameters.Add(new SqlParameter("@DAPAN", item.Value.DapAn));
                    adder.ExecuteNonQuery();
                }
                Program.conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi thêm chi tiết bài thi  " + e.Message, "", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Thêm chi tiết bài thi thành công", " ", MessageBoxButtons.OK);
            phut = 0;
            giay = 0;
        }

        public void luuVaoBangDiem()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                string sql = "";
                sql = "SELECT * FROM BANGDIEM";
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable(sql);
                BindingSource bdsBD = new BindingSource();
                bdsBD.DataSource = dt;

                if (bdsBD.Count == 0) IDBD = 1;
                else IDBD = Int32.Parse(((DataRowView)bdsBD[bdsBD.Count - 1])["IDBD"].ToString()) + 1;
                try
                {
                    sql = "INSERT INTO BANGDIEM ( IDBD, MAMH , MASV , LAN , NGAYTHI , DIEM , BAITHI ) "
                        + "VALUES  ( " +
                        "'" + IDBD + "' , -- IDBD - int \n" +
                        "'" + Program.maMH + "' , -- MAMH - char(5) \n" +
                        "'" + Program.username + "' , -- MASV - char(8) \n" +
                        " " + Program.lanThi + " , -- LAN - smallint \n" +
                        "'" + Program.ngayThi + "' , -- NGAYTHI - datetime \n" +
                        " " + diem + " , -- DIEM - float \n" +
                        "N'Test' -- BAITHI - nchar(10) \n" +
                        ")";
                    if (Program.ExecSqlNonQuery(sql) == 0)
                    {
                        MessageBox.Show("Thêm vào bảng điểm thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi ghi cơ sở dữ liệu  " + e.Message, "", MessageBoxButtons.OK);
                    return;
                }
                luuCTBT(IDBD);
            }
            else return;
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            giay--;
            if (giay == 0)
            {
                phut--;
                giay = 60;
            }
            if (phut == 0 && giay == 0)
                timer.Stop();
            hienThiTG();
        }

        private void btnXemKQ_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.mGroup == "SINHVIEN")
            {
                groupControl1.Enabled = false;
                frmXemKetQua fm = new frmXemKetQua();
                fm.ShowDialog();
            }
            if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "COSO")
            {
                XEMKQGV fm = new XEMKQGV(deThi);
                fm.ShowDialog();
            }           
        }
    }
}
