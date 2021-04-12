using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace THITN
{
    public partial class XtraReport_XemKQ : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_XemKQ(int maBD)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_XEM_KETQUATableAdapter1.Fill(ds1.SP_XEM_KETQUA, maBD);
        }

    }
}
