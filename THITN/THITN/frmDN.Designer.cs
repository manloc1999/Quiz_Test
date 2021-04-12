
namespace THITN
{
    partial class frmDN
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
            this.groupDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.inpMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.inpTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCS = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsPM = new THITN.dsPM();
            this.dsPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new THITN.dsPMTableAdapters.v_DS_PHANMANHTableAdapter();
            this.rbGiangVien = new System.Windows.Forms.RadioButton();
            this.rbSinhVien = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).BeginInit();
            this.groupDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDangNhap
            // 
            this.groupDangNhap.CausesValidation = false;
            this.groupDangNhap.Controls.Add(this.groupBox1);
            this.groupDangNhap.Controls.Add(this.btnDangNhap);
            this.groupDangNhap.Controls.Add(this.inpMatKhau);
            this.groupDangNhap.Controls.Add(this.inpTaiKhoan);
            this.groupDangNhap.Controls.Add(this.label3);
            this.groupDangNhap.Controls.Add(this.label2);
            this.groupDangNhap.Controls.Add(this.label1);
            this.groupDangNhap.Controls.Add(this.cbCS);
            this.groupDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDangNhap.Location = new System.Drawing.Point(0, 0);
            this.groupDangNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupDangNhap.Name = "groupDangNhap";
            this.groupDangNhap.Size = new System.Drawing.Size(1315, 772);
            this.groupDangNhap.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(551, 580);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(268, 61);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // inpMatKhau
            // 
            this.inpMatKhau.Location = new System.Drawing.Point(412, 489);
            this.inpMatKhau.Margin = new System.Windows.Forms.Padding(5);
            this.inpMatKhau.Name = "inpMatKhau";
            this.inpMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMatKhau.Properties.Appearance.Options.UseFont = true;
            this.inpMatKhau.Properties.PasswordChar = '*';
            this.inpMatKhau.Size = new System.Drawing.Size(499, 26);
            this.inpMatKhau.TabIndex = 4;
            // 
            // inpTaiKhoan
            // 
            this.inpTaiKhoan.Location = new System.Drawing.Point(412, 380);
            this.inpTaiKhoan.Margin = new System.Windows.Forms.Padding(5);
            this.inpTaiKhoan.Name = "inpTaiKhoan";
            this.inpTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.inpTaiKhoan.Size = new System.Drawing.Size(499, 26);
            this.inpTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 496);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 389);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cơ sở";
            // 
            // cbCS
            // 
            this.cbCS.DataSource = this.vDSPHANMANHBindingSource1;
            this.cbCS.DisplayMember = "TENCS";
            this.cbCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCS.FormattingEnabled = true;
            this.cbCS.Location = new System.Drawing.Point(412, 265);
            this.cbCS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbCS.Name = "cbCS";
            this.cbCS.Size = new System.Drawing.Size(495, 28);
            this.cbCS.TabIndex = 0;
            this.cbCS.ValueMember = "TENSERVER";
            this.cbCS.SelectedIndexChanged += new System.EventHandler(this.cbCS_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource1
            // 
            this.vDSPHANMANHBindingSource1.DataMember = "v_DS_PHANMANH";
            this.vDSPHANMANHBindingSource1.DataSource = this.dsPM;
            // 
            // dsPM
            // 
            this.dsPM.DataSetName = "dsPM";
            this.dsPM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsPMBindingSource
            // 
            this.dsPMBindingSource.DataSource = this.dsPM;
            this.dsPMBindingSource.Position = 0;
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "v_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.dsPMBindingSource;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // rbGiangVien
            // 
            this.rbGiangVien.AutoSize = true;
            this.rbGiangVien.Location = new System.Drawing.Point(18, 47);
            this.rbGiangVien.Name = "rbGiangVien";
            this.rbGiangVien.Size = new System.Drawing.Size(113, 25);
            this.rbGiangVien.TabIndex = 9;
            this.rbGiangVien.TabStop = true;
            this.rbGiangVien.Text = "Giảng Viên";
            this.rbGiangVien.UseVisualStyleBackColor = true;
            this.rbGiangVien.CheckedChanged += new System.EventHandler(this.rbGiangVien_CheckedChanged);
            // 
            // rbSinhVien
            // 
            this.rbSinhVien.AutoSize = true;
            this.rbSinhVien.Location = new System.Drawing.Point(251, 47);
            this.rbSinhVien.Name = "rbSinhVien";
            this.rbSinhVien.Size = new System.Drawing.Size(102, 25);
            this.rbSinhVien.TabIndex = 10;
            this.rbSinhVien.TabStop = true;
            this.rbSinhVien.Text = "Sinh Viên";
            this.rbSinhVien.UseVisualStyleBackColor = true;
            this.rbSinhVien.CheckedChanged += new System.EventHandler(this.rbSinhVien_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSinhVien);
            this.groupBox1.Controls.Add(this.rbGiangVien);
            this.groupBox1.Location = new System.Drawing.Point(472, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 772);
            this.Controls.Add(this.groupDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDN";
            this.Text = "frmDN";
            this.Load += new System.EventHandler(this.frmDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).EndInit();
            this.groupDangNhap.ResumeLayout(false);
            this.groupDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private DevExpress.XtraEditors.TextEdit inpMatKhau;
        private DevExpress.XtraEditors.TextEdit inpTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCS;
        private System.Windows.Forms.BindingSource dsPMBindingSource;
        private dsPM dsPM;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private dsPMTableAdapters.v_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource1;
        private System.Windows.Forms.RadioButton rbSinhVien;
        private System.Windows.Forms.RadioButton rbGiangVien;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}