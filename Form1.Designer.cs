namespace CRUDMahasiswa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBAkademikADODataSet = new CRUDMahasiswa.DBAkademikADODataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.dtpTL = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mahasiswaTableAdapter = new CRUDMahasiswa.DBAkademikADODataSetTableAdapters.MahasiswaTableAdapter();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnResetData = new System.Windows.Forms.Button();
            this.btnTestInjection = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnUploadGambar = new System.Windows.Forms.Button();
            this.fotoMhs = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImportFormExcel = new System.Windows.Forms.Button();
            this.btnImporttoDB = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.Kembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAkademikADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIM
            // 
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.txtNIM.Location = new System.Drawing.Point(202, 127);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(200, 22);
            this.txtNIM.TabIndex = 0;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.dBAkademikADODataSet;
            // 
            // dBAkademikADODataSet
            // 
            this.dBAkademikADODataSet.DataSetName = "DBAkademikADODataSet";
            this.dBAkademikADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "KodeProdi", true));
            this.txtKodeProdi.Location = new System.Drawing.Point(202, 244);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(200, 22);
            this.txtKodeProdi.TabIndex = 2;
            // 
            // txtNama
            // 
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Nama", true));
            this.txtNama.Location = new System.Drawing.Point(202, 155);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 22);
            this.txtNama.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Alamat", true));
            this.txtAlamat.Location = new System.Drawing.Point(202, 272);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 22);
            this.txtAlamat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kode Prodi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alamat";
            // 
            // cmbJK
            // 
            this.cmbJK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "JenisKelamin", true));
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Location = new System.Drawing.Point(202, 186);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(200, 24);
            this.cmbJK.TabIndex = 12;
            // 
            // dtpTL
            // 
            this.dtpTL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "TanggalLahir", true));
            this.dtpTL.Location = new System.Drawing.Point(202, 216);
            this.dtpTL.Name = "dtpTL";
            this.dtpTL.Size = new System.Drawing.Size(200, 22);
            this.dtpTL.TabIndex = 13;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(488, 41);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(569, 483);
            this.dgvData.TabIndex = 14;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.mahasiswaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1378, 27);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(71, 358);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(107, 44);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(297, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 44);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(71, 409);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 44);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(184, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 44);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(184, 409);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 44);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Silahkan isi form dibawah ini";
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(297, 409);
            this.btnResetData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(104, 44);
            this.btnResetData.TabIndex = 23;
            this.btnResetData.Text = "Reset";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // btnTestInjection
            // 
            this.btnTestInjection.Location = new System.Drawing.Point(187, 458);
            this.btnTestInjection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTestInjection.Name = "btnTestInjection";
            this.btnTestInjection.Size = new System.Drawing.Size(104, 44);
            this.btnTestInjection.TabIndex = 24;
            this.btnTestInjection.Text = "Test Injection";
            this.btnTestInjection.UseVisualStyleBackColor = true;
            this.btnTestInjection.Click += new System.EventHandler(this.btnTestInjection_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(202, 313);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 16);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total Mahasiswa";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(71, 458);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 44);
            this.btnReport.TabIndex = 26;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnUploadGambar
            // 
            this.btnUploadGambar.Location = new System.Drawing.Point(1130, 323);
            this.btnUploadGambar.Name = "btnUploadGambar";
            this.btnUploadGambar.Size = new System.Drawing.Size(181, 44);
            this.btnUploadGambar.TabIndex = 27;
            this.btnUploadGambar.Text = "Upload Gambar";
            this.btnUploadGambar.UseVisualStyleBackColor = true;
            this.btnUploadGambar.Click += new System.EventHandler(this.btnUploadGambar_Click);
            // 
            // fotoMhs
            // 
            this.fotoMhs.Location = new System.Drawing.Point(1130, 114);
            this.fotoMhs.Name = "fotoMhs";
            this.fotoMhs.Size = new System.Drawing.Size(181, 203);
            this.fotoMhs.TabIndex = 28;
            this.fotoMhs.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnImportFormExcel
            // 
            this.btnImportFormExcel.Location = new System.Drawing.Point(1130, 374);
            this.btnImportFormExcel.Name = "btnImportFormExcel";
            this.btnImportFormExcel.Size = new System.Drawing.Size(181, 44);
            this.btnImportFormExcel.TabIndex = 30;
            this.btnImportFormExcel.Text = "Import Form Excel";
            this.btnImportFormExcel.UseVisualStyleBackColor = true;
            this.btnImportFormExcel.Click += new System.EventHandler(this.btnImportFormExcel_Click);
            // 
            // btnImporttoDB
            // 
            this.btnImporttoDB.Location = new System.Drawing.Point(1130, 423);
            this.btnImporttoDB.Name = "btnImporttoDB";
            this.btnImporttoDB.Size = new System.Drawing.Size(181, 44);
            this.btnImporttoDB.TabIndex = 31;
            this.btnImporttoDB.Text = "Import to Database";
            this.btnImporttoDB.UseVisualStyleBackColor = true;
            this.btnImporttoDB.Click += new System.EventHandler(this.btnImporttoDB_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(409, 127);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(54, 23);
            this.btnCari.TabIndex = 32;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // Kembali
            // 
            this.Kembali.Location = new System.Drawing.Point(1130, 480);
            this.Kembali.Name = "Kembali";
            this.Kembali.Size = new System.Drawing.Size(181, 44);
            this.Kembali.TabIndex = 33;
            this.Kembali.Text = "Dashboard";
            this.Kembali.UseVisualStyleBackColor = true;
            this.Kembali.Click += new System.EventHandler(this.Kembali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 557);
            this.Controls.Add(this.Kembali);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnImporttoDB);
            this.Controls.Add(this.btnImportFormExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoMhs);
            this.Controls.Add(this.btnUploadGambar);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTestInjection);
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtpTL);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.txtNIM);
            this.Name = "Form1";
            this.Text = "CRUD Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAkademikADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.DateTimePicker dtpTL;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DBAkademikADODataSet dBAkademikADODataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private DBAkademikADODataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Button btnTestInjection;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnUploadGambar;
        private System.Windows.Forms.PictureBox fotoMhs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImportFormExcel;
        private System.Windows.Forms.Button btnImporttoDB;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button Kembali;
    }
}

