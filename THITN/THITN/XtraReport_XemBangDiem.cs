using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class XtraReport_XemBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_XemBangDiem(string maLop, string maMH, string lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_XEM_BANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_XEM_BANGDIEMTableAdapter.Fill(ds1.SP_XEM_BANGDIEM, maLop, maMH, Int16.Parse(lan));
        }

    }
}
