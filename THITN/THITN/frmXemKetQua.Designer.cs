
namespace THITN
{
    partial class frmXemKetQua
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
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label mASVLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new THITN.DS();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.labelTrinhDo = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.labelCoSo = new System.Windows.Forms.Label();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_XEM_KETQUABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_XEM_KETQUATableAdapter = new THITN.DSTableAdapters.SP_XEM_KETQUATableAdapter();
            this.tableAdapterManager = new THITN.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new THITN.DSTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new THITN.DSTableAdapters.SINHVIENTableAdapter();
            this.mONHOCTableAdapter = new THITN.DSTableAdapters.MONHOCTableAdapter();
            this.sP_XEM_KETQUABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gcXemKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAPAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDACHON = new DevExpress.XtraGrid.Columns.GridColumn();
            tENMHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMHLabel.Location = new System.Drawing.Point(81, 180);
            tENMHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(130, 21);
            tENMHLabel.TabIndex = 60;
            tENMHLabel.Text = "Tên Môn Học : ";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(110, 243);
            tENLOPLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(89, 21);
            tENLOPLabel.TabIndex = 58;
            tENLOPLabel.Text = "Tên Lớp : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(705, 137);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 21);
            label1.TabIndex = 48;
            label1.Text = "Lần : ";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(122, 60);
            mASVLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(77, 21);
            mASVLabel.TabIndex = 65;
            mASVLabel.Text = "Mã SV : ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbHoTen);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(mASVLabel);
            this.panelControl1.Controls.Add(this.cmbMaSV);
            this.panelControl1.Controls.Add(tENMHLabel);
            this.panelControl1.Controls.Add(this.cmbTenMH);
            this.panelControl1.Controls.Add(tENLOPLabel);
            this.panelControl1.Controls.Add(this.cmbTenLop);
            this.panelControl1.Controls.Add(this.btnIn);
            this.panelControl1.Controls.Add(this.cmbLan);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.labelTrinhDo);
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.cmbCoSo);
            this.panelControl1.Controls.Add(this.labelCoSo);
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(this.cmbTrinhDo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1548, 410);
            this.panelControl1.TabIndex = 0;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(264, 116);
            this.cmbHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(373, 28);
            this.cmbHoTen.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Họ Tên : ";
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataSource = this.sINHVIENBindingSource;
            this.cmbMaSV.DisplayMember = "MASV";
            this.cmbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(264, 55);
            this.cmbMaSV.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(240, 28);
            this.cmbMaSV.TabIndex = 66;
            this.cmbMaSV.ValueMember = "MASV";
            this.cmbMaSV.SelectedIndexChanged += new System.EventHandler(this.cmbMaSV_SelectedIndexChanged);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.mONHOCBindingSource;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(264, 177);
            this.cmbTenMH.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(373, 28);
            this.cmbTenMH.TabIndex = 62;
            this.cmbTenMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(264, 236);
            this.cmbTenLop.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(372, 28);
            this.cmbTenLop.TabIndex = 61;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Black;
            this.btnIn.Location = new System.Drawing.Point(705, 320);
            this.btnIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(182, 49);
            this.btnIn.TabIndex = 59;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbLan
            // 
            this.cmbLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Location = new System.Drawing.Point(810, 130);
            this.cmbLan.Margin = new System.Windows.Forms.Padding(5);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(232, 28);
            this.cmbLan.TabIndex = 49;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Location = new System.Drawing.Point(455, 320);
            this.btnXem.Margin = new System.Windows.Forms.Padding(5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(182, 49);
            this.btnXem.TabIndex = 50;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // labelTrinhDo
            // 
            this.labelTrinhDo.AutoSize = true;
            this.labelTrinhDo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrinhDo.Location = new System.Drawing.Point(705, 225);
            this.labelTrinhDo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTrinhDo.Name = "labelTrinhDo";
            this.labelTrinhDo.Size = new System.Drawing.Size(94, 21);
            this.labelTrinhDo.TabIndex = 55;
            this.labelTrinhDo.Text = "Trình Độ : ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(927, 320);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(182, 49);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(797, 40);
            this.cmbCoSo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(373, 28);
            this.cmbCoSo.TabIndex = 52;
            this.cmbCoSo.SelectedIndexChanged += new System.EventHandler(this.cmbCoSo_SelectedIndexChanged);
            // 
            // labelCoSo
            // 
            this.labelCoSo.AutoSize = true;
            this.labelCoSo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoSo.Location = new System.Drawing.Point(684, 40);
            this.labelCoSo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCoSo.Name = "labelCoSo";
            this.labelCoSo.Size = new System.Drawing.Size(73, 21);
            this.labelCoSo.TabIndex = 53;
            this.labelCoSo.Text = "Cơ Sở : ";
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrinhDo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Location = new System.Drawing.Point(810, 222);
            this.cmbTrinhDo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(232, 28);
            this.cmbTrinhDo.TabIndex = 57;
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
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_XEM_KETQUABindingSource1
            // 
            this.sP_XEM_KETQUABindingSource1.DataMember = "SP_XEM_KETQUA";
            this.sP_XEM_KETQUABindingSource1.DataSource = this.dS;
            // 
            // gcXemKetQua
            // 
            this.gcXemKetQua.DataSource = this.sP_XEM_KETQUABindingSource1;
            this.gcXemKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemKetQua.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            gridLevelNode1.RelationName = "Level1";
            this.gcXemKetQua.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcXemKetQua.Location = new System.Drawing.Point(0, 410);
            this.gcXemKetQua.MainView = this.gridView1;
            this.gcXemKetQua.Margin = new System.Windows.Forms.Padding(5);
            this.gcXemKetQua.Name = "gcXemKetQua";
            this.gcXemKetQua.Size = new System.Drawing.Size(1548, 434);
            this.gcXemKetQua.TabIndex = 2;
            this.gcXemKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colCAUHOI,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAPAN,
            this.colDACHON});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.gcXemKetQua;
            this.gridView1.Name = "gridView1";
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 31;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 64;
            // 
            // colCAUHOI
            // 
            this.colCAUHOI.FieldName = "CAUHOI";
            this.colCAUHOI.MinWidth = 31;
            this.colCAUHOI.Name = "colCAUHOI";
            this.colCAUHOI.Visible = true;
            this.colCAUHOI.VisibleIndex = 1;
            this.colCAUHOI.Width = 54;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 31;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            this.colNOIDUNG.Width = 363;
            // 
            // colA
            // 
            this.colA.FieldName = "A";
            this.colA.MinWidth = 31;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            this.colA.Width = 246;
            // 
            // colB
            // 
            this.colB.FieldName = "B";
            this.colB.MinWidth = 31;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            this.colB.Width = 257;
            // 
            // colC
            // 
            this.colC.FieldName = "C";
            this.colC.MinWidth = 31;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            this.colC.Width = 211;
            // 
            // colD
            // 
            this.colD.FieldName = "D";
            this.colD.MinWidth = 31;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            this.colD.Width = 177;
            // 
            // colDAPAN
            // 
            this.colDAPAN.FieldName = "DAPAN";
            this.colDAPAN.MinWidth = 31;
            this.colDAPAN.Name = "colDAPAN";
            this.colDAPAN.Visible = true;
            this.colDAPAN.VisibleIndex = 7;
            this.colDAPAN.Width = 71;
            // 
            // colDACHON
            // 
            this.colDACHON.FieldName = "DACHON";
            this.colDACHON.MinWidth = 31;
            this.colDACHON.Name = "colDACHON";
            this.colDACHON.Visible = true;
            this.colDACHON.VisibleIndex = 8;
            // 
            // frmXemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 844);
            this.Controls.Add(this.gcXemKetQua);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemKetQua";
            this.Text = "frmXemKetQua";
            this.Load += new System.EventHandler(this.frmXemKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_XEM_KETQUABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label labelTrinhDo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private System.Windows.Forms.Label labelCoSo;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_XEM_KETQUABindingSource;
        private DSTableAdapters.SP_XEM_KETQUATableAdapter sP_XEM_KETQUATableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.ComboBox cmbMaSV;
        //private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource;
        //private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource2;
        //private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource sP_XEM_KETQUABindingSource1;
        private DevExpress.XtraGrid.GridControl gcXemKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAPAN;
        private DevExpress.XtraGrid.Columns.GridColumn colDACHON;
    }
}