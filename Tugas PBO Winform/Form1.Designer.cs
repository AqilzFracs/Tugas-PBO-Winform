namespace Tugas_PBO_Winform
{
    partial class Form_TokoLaptop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TokoLaptop));
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridLaptop = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_DeleteLaptop = new System.Windows.Forms.Button();
            this.bt_UpdateLaptop = new System.Windows.Forms.Button();
            this.bt_Insert_Laptop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_HargaLaptop = new System.Windows.Forms.TextBox();
            this.tb_StokLaptop = new System.Windows.Forms.TextBox();
            this.tb_NamaLaptop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridDetailTransaksi = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_selesai = new System.Windows.Forms.Button();
            this.bt_Insert_detail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IDLaptop = new System.Windows.Forms.TextBox();
            this.tb_JumlahBarang = new System.Windows.Forms.TextBox();
            this.tb_IDTransaksi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridLaptop2 = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTransaksi = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.lab_Condition = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_Detail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lab_Sunrise = new System.Windows.Forms.Label();
            this.lab_Sunset = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lab_Temp = new System.Windows.Forms.Label();
            this.lab_Pressure = new System.Windows.Forms.Label();
            this.lab_Windspeed = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaptop)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailTransaksi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaptop2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Laptop";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Laptop";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stok";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridLaptop);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Laptop";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridLaptop
            // 
            this.dataGridLaptop.AllowUserToAddRows = false;
            this.dataGridLaptop.AllowUserToDeleteRows = false;
            this.dataGridLaptop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLaptop.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridLaptop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLaptop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridLaptop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLaptop.Location = new System.Drawing.Point(3, 228);
            this.dataGridLaptop.Name = "dataGridLaptop";
            this.dataGridLaptop.ReadOnly = true;
            this.dataGridLaptop.RowHeadersVisible = false;
            this.dataGridLaptop.RowHeadersWidth = 51;
            this.dataGridLaptop.RowTemplate.Height = 24;
            this.dataGridLaptop.Size = new System.Drawing.Size(987, 225);
            this.dataGridLaptop.TabIndex = 1;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID Laptop";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nama Laptop";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Harga";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Stok";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.bt_DeleteLaptop);
            this.panel1.Controls.Add(this.bt_UpdateLaptop);
            this.panel1.Controls.Add(this.bt_Insert_Laptop);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_HargaLaptop);
            this.panel1.Controls.Add(this.tb_StokLaptop);
            this.panel1.Controls.Add(this.tb_NamaLaptop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 225);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label7.Location = new System.Drawing.Point(777, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_Search.Location = new System.Drawing.Point(781, 191);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(189, 28);
            this.tb_Search.TabIndex = 16;
            this.tb_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_DeleteLaptop
            // 
            this.bt_DeleteLaptop.Location = new System.Drawing.Point(109, 192);
            this.bt_DeleteLaptop.Name = "bt_DeleteLaptop";
            this.bt_DeleteLaptop.Size = new System.Drawing.Size(98, 27);
            this.bt_DeleteLaptop.TabIndex = 15;
            this.bt_DeleteLaptop.Text = "Delete";
            this.bt_DeleteLaptop.UseVisualStyleBackColor = true;
            this.bt_DeleteLaptop.Click += new System.EventHandler(this.bt_DeleteLaptop_Click);
            // 
            // bt_UpdateLaptop
            // 
            this.bt_UpdateLaptop.Location = new System.Drawing.Point(5, 192);
            this.bt_UpdateLaptop.Name = "bt_UpdateLaptop";
            this.bt_UpdateLaptop.Size = new System.Drawing.Size(98, 27);
            this.bt_UpdateLaptop.TabIndex = 14;
            this.bt_UpdateLaptop.Text = "Update";
            this.bt_UpdateLaptop.UseVisualStyleBackColor = true;
            this.bt_UpdateLaptop.Click += new System.EventHandler(this.bt_UpdateLaptop_Click);
            // 
            // bt_Insert_Laptop
            // 
            this.bt_Insert_Laptop.Location = new System.Drawing.Point(195, 127);
            this.bt_Insert_Laptop.Name = "bt_Insert_Laptop";
            this.bt_Insert_Laptop.Size = new System.Drawing.Size(88, 32);
            this.bt_Insert_Laptop.TabIndex = 13;
            this.bt_Insert_Laptop.Text = "Insert";
            this.bt_Insert_Laptop.UseVisualStyleBackColor = true;
            this.bt_Insert_Laptop.Click += new System.EventHandler(this.bt_Insert_Laptop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nama Laptop ";
            // 
            // tb_HargaLaptop
            // 
            this.tb_HargaLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_HargaLaptop.Location = new System.Drawing.Point(195, 52);
            this.tb_HargaLaptop.Name = "tb_HargaLaptop";
            this.tb_HargaLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_HargaLaptop.TabIndex = 11;
            // 
            // tb_StokLaptop
            // 
            this.tb_StokLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_StokLaptop.Location = new System.Drawing.Point(195, 93);
            this.tb_StokLaptop.Name = "tb_StokLaptop";
            this.tb_StokLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_StokLaptop.TabIndex = 12;
            // 
            // tb_NamaLaptop
            // 
            this.tb_NamaLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_NamaLaptop.Location = new System.Drawing.Point(195, 14);
            this.tb_NamaLaptop.Name = "tb_NamaLaptop";
            this.tb_NamaLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_NamaLaptop.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harga ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stok ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridDetailTransaksi);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage3.Size = new System.Drawing.Size(993, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detail Transaksi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridDetailTransaksi
            // 
            this.dataGridDetailTransaksi.AllowUserToAddRows = false;
            this.dataGridDetailTransaksi.AllowUserToDeleteRows = false;
            this.dataGridDetailTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetailTransaksi.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridDetailTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dataGridDetailTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDetailTransaksi.Location = new System.Drawing.Point(3, 233);
            this.dataGridDetailTransaksi.Name = "dataGridDetailTransaksi";
            this.dataGridDetailTransaksi.ReadOnly = true;
            this.dataGridDetailTransaksi.RowHeadersVisible = false;
            this.dataGridDetailTransaksi.RowHeadersWidth = 51;
            this.dataGridDetailTransaksi.RowTemplate.Height = 24;
            this.dataGridDetailTransaksi.Size = new System.Drawing.Size(987, 220);
            this.dataGridDetailTransaksi.TabIndex = 1;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "ID Detail Transaksi";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "ID Transaksi";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "ID Laptop";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Jumlah Barang";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.bt_selesai);
            this.panel2.Controls.Add(this.bt_Insert_detail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tb_IDLaptop);
            this.panel2.Controls.Add(this.tb_JumlahBarang);
            this.panel2.Controls.Add(this.tb_IDTransaksi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridLaptop2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 230);
            this.panel2.TabIndex = 0;
            // 
            // bt_selesai
            // 
            this.bt_selesai.Location = new System.Drawing.Point(320, 129);
            this.bt_selesai.Name = "bt_selesai";
            this.bt_selesai.Size = new System.Drawing.Size(105, 44);
            this.bt_selesai.TabIndex = 20;
            this.bt_selesai.Text = "Selesai";
            this.bt_selesai.UseVisualStyleBackColor = true;
            this.bt_selesai.Click += new System.EventHandler(this.bt_selesai_Click);
            // 
            // bt_Insert_detail
            // 
            this.bt_Insert_detail.Location = new System.Drawing.Point(198, 129);
            this.bt_Insert_detail.Name = "bt_Insert_detail";
            this.bt_Insert_detail.Size = new System.Drawing.Size(105, 44);
            this.bt_Insert_detail.TabIndex = 19;
            this.bt_Insert_detail.Text = "Insert";
            this.bt_Insert_detail.UseVisualStyleBackColor = true;
            this.bt_Insert_detail.Click += new System.EventHandler(this.bt_Insert_detail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID Transaksi";
            // 
            // tb_IDLaptop
            // 
            this.tb_IDLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_IDLaptop.Location = new System.Drawing.Point(198, 54);
            this.tb_IDLaptop.Name = "tb_IDLaptop";
            this.tb_IDLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_IDLaptop.TabIndex = 17;
            // 
            // tb_JumlahBarang
            // 
            this.tb_JumlahBarang.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_JumlahBarang.Location = new System.Drawing.Point(198, 95);
            this.tb_JumlahBarang.Name = "tb_JumlahBarang";
            this.tb_JumlahBarang.Size = new System.Drawing.Size(301, 28);
            this.tb_JumlahBarang.TabIndex = 18;
            // 
            // tb_IDTransaksi
            // 
            this.tb_IDTransaksi.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_IDTransaksi.Location = new System.Drawing.Point(198, 16);
            this.tb_IDTransaksi.Name = "tb_IDTransaksi";
            this.tb_IDTransaksi.Size = new System.Drawing.Size(301, 28);
            this.tb_IDTransaksi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID Laptop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label6.Location = new System.Drawing.Point(23, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jumlah Barang";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridLaptop2
            // 
            this.dataGridLaptop2.AllowUserToAddRows = false;
            this.dataGridLaptop2.AllowUserToDeleteRows = false;
            this.dataGridLaptop2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLaptop2.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridLaptop2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLaptop2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridLaptop2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridLaptop2.Location = new System.Drawing.Point(651, 0);
            this.dataGridLaptop2.Name = "dataGridLaptop2";
            this.dataGridLaptop2.ReadOnly = true;
            this.dataGridLaptop2.RowHeadersVisible = false;
            this.dataGridLaptop2.RowHeadersWidth = 51;
            this.dataGridLaptop2.RowTemplate.Height = 24;
            this.dataGridLaptop2.Size = new System.Drawing.Size(336, 230);
            this.dataGridLaptop2.TabIndex = 0;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "ID_Laptop";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Nama Laptop";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Harga";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Stok";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridTransaksi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaksi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridTransaksi
            // 
            this.dataGridTransaksi.AllowUserToAddRows = false;
            this.dataGridTransaksi.AllowUserToDeleteRows = false;
            this.dataGridTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransaksi.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTransaksi.Location = new System.Drawing.Point(3, 3);
            this.dataGridTransaksi.Name = "dataGridTransaksi";
            this.dataGridTransaksi.ReadOnly = true;
            this.dataGridTransaksi.RowHeadersVisible = false;
            this.dataGridTransaksi.RowHeadersWidth = 51;
            this.dataGridTransaksi.RowTemplate.Height = 24;
            this.dataGridTransaksi.Size = new System.Drawing.Size(991, 445);
            this.dataGridTransaksi.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID Transaksi";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tanggal Transaksi ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Status Transaksi";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.bt_search);
            this.tabPage4.Controls.Add(this.lab_Windspeed);
            this.tabPage4.Controls.Add(this.lab_Pressure);
            this.tabPage4.Controls.Add(this.lab_Temp);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.lab_Sunset);
            this.tabPage4.Controls.Add(this.lab_Sunrise);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.lab_Detail);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.lab_Condition);
            this.tabPage4.Controls.Add(this.weatherIcon);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.tb_city);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(997, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Weather APP";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "City :";
            // 
            // tb_city
            // 
            this.tb_city.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_city.Location = new System.Drawing.Point(93, 21);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(215, 28);
            this.tb_city.TabIndex = 17;
            // 
            // weatherIcon
            // 
            this.weatherIcon.Location = new System.Drawing.Point(93, 93);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(139, 64);
            this.weatherIcon.TabIndex = 18;
            this.weatherIcon.TabStop = false;
            // 
            // lab_Condition
            // 
            this.lab_Condition.AutoSize = true;
            this.lab_Condition.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Condition.Location = new System.Drawing.Point(88, 200);
            this.lab_Condition.Name = "lab_Condition";
            this.lab_Condition.Size = new System.Drawing.Size(95, 25);
            this.lab_Condition.TabIndex = 19;
            this.lab_Condition.Text = "Condition";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sunset :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Sunrise : ";
            // 
            // lab_Detail
            // 
            this.lab_Detail.AutoSize = true;
            this.lab_Detail.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Detail.Location = new System.Drawing.Point(88, 248);
            this.lab_Detail.Name = "lab_Detail";
            this.lab_Detail.Size = new System.Drawing.Size(62, 25);
            this.lab_Detail.TabIndex = 22;
            this.lab_Detail.Text = "Detail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(469, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Pressure :";
            // 
            // lab_Sunrise
            // 
            this.lab_Sunrise.AutoSize = true;
            this.lab_Sunrise.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunrise.Location = new System.Drawing.Point(174, 292);
            this.lab_Sunrise.Name = "lab_Sunrise";
            this.lab_Sunrise.Size = new System.Drawing.Size(47, 25);
            this.lab_Sunrise.TabIndex = 24;
            this.lab_Sunrise.Text = "N/A";
            // 
            // lab_Sunset
            // 
            this.lab_Sunset.AutoSize = true;
            this.lab_Sunset.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunset.Location = new System.Drawing.Point(174, 335);
            this.lab_Sunset.Name = "lab_Sunset";
            this.lab_Sunset.Size = new System.Drawing.Size(47, 25);
            this.lab_Sunset.TabIndex = 25;
            this.lab_Sunset.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(469, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Temperature :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(469, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "Wind Speed :";
            // 
            // lab_Temp
            // 
            this.lab_Temp.AutoSize = true;
            this.lab_Temp.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Temp.Location = new System.Drawing.Point(606, 200);
            this.lab_Temp.Name = "lab_Temp";
            this.lab_Temp.Size = new System.Drawing.Size(47, 25);
            this.lab_Temp.TabIndex = 28;
            this.lab_Temp.Text = "N/A";
            // 
            // lab_Pressure
            // 
            this.lab_Pressure.AutoSize = true;
            this.lab_Pressure.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Pressure.Location = new System.Drawing.Point(572, 248);
            this.lab_Pressure.Name = "lab_Pressure";
            this.lab_Pressure.Size = new System.Drawing.Size(47, 25);
            this.lab_Pressure.TabIndex = 29;
            this.lab_Pressure.Text = "N/A";
            // 
            // lab_Windspeed
            // 
            this.lab_Windspeed.AutoSize = true;
            this.lab_Windspeed.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Windspeed.Location = new System.Drawing.Point(600, 292);
            this.lab_Windspeed.Name = "lab_Windspeed";
            this.lab_Windspeed.Size = new System.Drawing.Size(47, 25);
            this.lab_Windspeed.TabIndex = 30;
            this.lab_Windspeed.Text = "N/A";
            // 
            // bt_search
            // 
            this.bt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Location = new System.Drawing.Point(314, 21);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 28);
            this.bt_search.TabIndex = 31;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // Form_TokoLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_TokoLaptop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toko Laptop";
            this.Load += new System.EventHandler(this.Form_TokoLaptop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaptop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailTransaksi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaptop2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridLaptop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_DeleteLaptop;
        private System.Windows.Forms.Button bt_UpdateLaptop;
        private System.Windows.Forms.Button bt_Insert_Laptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_HargaLaptop;
        private System.Windows.Forms.TextBox tb_StokLaptop;
        private System.Windows.Forms.TextBox tb_NamaLaptop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridView dataGridDetailTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_selesai;
        private System.Windows.Forms.Button bt_Insert_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_IDLaptop;
        private System.Windows.Forms.TextBox tb_JumlahBarang;
        private System.Windows.Forms.TextBox tb_IDTransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridLaptop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lab_Sunset;
        private System.Windows.Forms.Label lab_Sunrise;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lab_Detail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_Condition;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label lab_Windspeed;
        private System.Windows.Forms.Label lab_Pressure;
        private System.Windows.Forms.Label lab_Temp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bt_search;
    }
}

