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
    public partial class XEMKQGV : Form
    {
        public XEMKQGV(Dictionary<int, CauHoi> cauhoi)
        {
            InitializeComponent();
            
            //gvKQ.Rows.Clear();


                foreach (KeyValuePair<int, CauHoi> item in cauhoi)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(gvKQ);

                newRow.Cells[0].Value = item.Key;
                newRow.Cells[1].Value = item.Value.IDCauHoi;
                newRow.Cells[2].Value = item.Value.NoiDung;
                newRow.Cells[3].Value = item.Value.A;
                newRow.Cells[4].Value = item.Value.B;
                newRow.Cells[5].Value = item.Value.C;
                newRow.Cells[6].Value = item.Value.D;
                newRow.Cells[7].Value = item.Value.DapAn;
                newRow.Cells[8].Value = item.Value.DaChon;               

                    gvKQ.Rows.Add(newRow);
            }
        }
    }
}
