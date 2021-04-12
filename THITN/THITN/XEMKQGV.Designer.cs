
namespace THITN
{
    partial class XEMKQGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gvKQ = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAUHOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAPAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DACHON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sP_XEM_KETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new THITN.DS();
            this.sP_XEM_KETQUATableAdapter = new THITN.DSTableAdapters.SP_XEM_KETQUATableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gvKQ);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1924, 1055);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gvKQ
            // 
            this.gvKQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CAUHOI,
            this.NOIDUNG,
            this.A,
            this.B,
            this.C,
            this.D,
            this.DAPAN,
            this.DACHON});
            this.gvKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvKQ.Location = new System.Drawing.Point(2, 28);
            this.gvKQ.Margin = new System.Windows.Forms.Padding(4);
            this.gvKQ.Name = "gvKQ";
            this.gvKQ.RowHeadersWidth = 51;
            this.gvKQ.RowTemplate.Height = 24;
            this.gvKQ.Size = new System.Drawing.Size(1920, 1025);
            this.gvKQ.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // CAUHOI
            // 
            this.CAUHOI.HeaderText = "CAUHOI";
            this.CAUHOI.MinimumWidth = 6;
            this.CAUHOI.Name = "CAUHOI";
            this.CAUHOI.Width = 80;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.HeaderText = "NOIDUNG";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 250;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.Width = 170;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.MinimumWidth = 6;
            this.B.Name = "B";
            this.B.Width = 170;
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.Width = 170;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.MinimumWidth = 6;
            this.D.Name = "D";
            this.D.Width = 170;
            // 
            // DAPAN
            // 
            this.DAPAN.HeaderText = "DAPAN";
            this.DAPAN.MinimumWidth = 6;
            this.DAPAN.Name = "DAPAN";
            this.DAPAN.Width = 60;
            // 
            // DACHON
            // 
            this.DACHON.HeaderText = "DACHON";
            this.DACHON.MinimumWidth = 6;
            this.DACHON.Name = "DACHON";
            this.DACHON.Width = 60;
            // 
            // sP_XEM_KETQUABindingSource
            // 
            this.sP_XEM_KETQUABindingSource.DataMember = "SP_XEM_KETQUA";
            this.sP_XEM_KETQUABindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_XEM_KETQUATableAdapter
            // 
            this.sP_XEM_KETQUATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // XEMKQGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XEMKQGV";
            this.Text = "XEMKQGV";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_XEM_KETQUABindingSource;
        private DSTableAdapters.SP_XEM_KETQUATableAdapter sP_XEM_KETQUATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gvKQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAUHOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAPAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DACHON;
    }
}