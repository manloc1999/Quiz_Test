using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class XtraReport_XemDSDK : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_XemDSDK(string tuNgay, string denNgay)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_XEM_DSDKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_XEM_DSDKTableAdapter.Fill(ds1.SP_XEM_DSDK, DateTime.Parse(tuNgay), DateTime.Parse(denNgay));
        }

    }
}
