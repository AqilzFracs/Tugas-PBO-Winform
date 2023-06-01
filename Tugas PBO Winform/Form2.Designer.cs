namespace Tugas_PBO_Winform
{
    partial class UpdateLaptop
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
            this.bt_Update_Laptop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_HargaLaptop = new System.Windows.Forms.TextBox();
            this.tb_StokLaptop = new System.Windows.Forms.TextBox();
            this.tb_IDLaptop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_NamaLaptop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Update_Laptop
            // 
            this.bt_Update_Laptop.Location = new System.Drawing.Point(171, 218);
            this.bt_Update_Laptop.Name = "bt_Update_Laptop";
            this.bt_Update_Laptop.Size = new System.Drawing.Size(150, 45);
            this.bt_Update_Laptop.TabIndex = 19;
            this.bt_Update_Laptop.Text = "Update";
            this.bt_Update_Laptop.UseVisualStyleBackColor = true;
            this.bt_Update_Laptop.Click += new System.EventHandler(this.bt_Insert_Laptop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nama Laptop ";
            // 
            // tb_HargaLaptop
            // 
            this.tb_HargaLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_HargaLaptop.Location = new System.Drawing.Point(203, 111);
            this.tb_HargaLaptop.Name = "tb_HargaLaptop";
            this.tb_HargaLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_HargaLaptop.TabIndex = 6;
            // 
            // tb_StokLaptop
            // 
            this.tb_StokLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_StokLaptop.Location = new System.Drawing.Point(203, 152);
            this.tb_StokLaptop.Name = "tb_StokLaptop";
            this.tb_StokLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_StokLaptop.TabIndex = 8;
            // 
            // tb_IDLaptop
            // 
            this.tb_IDLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_IDLaptop.Location = new System.Drawing.Point(203, 30);
            this.tb_IDLaptop.Name = "tb_IDLaptop";
            this.tb_IDLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_IDLaptop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Harga ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Stok ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.bt_Update_Laptop);
            this.panel1.Controls.Add(this.tb_HargaLaptop);
            this.panel1.Controls.Add(this.tb_NamaLaptop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_IDLaptop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 290);
            this.panel1.TabIndex = 20;
            // 
            // tb_NamaLaptop
            // 
            this.tb_NamaLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_NamaLaptop.Location = new System.Drawing.Point(203, 73);
            this.tb_NamaLaptop.Name = "tb_NamaLaptop";
            this.tb_NamaLaptop.Size = new System.Drawing.Size(301, 28);
            this.tb_NamaLaptop.TabIndex = 1;
            this.tb_NamaLaptop.TextChanged += new System.EventHandler(this.tb_IDLaptop_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label4.Location = new System.Drawing.Point(28, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID Laptop";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateLaptop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_StokLaptop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateLaptop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Laptop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Update_Laptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_HargaLaptop;
        private System.Windows.Forms.TextBox tb_StokLaptop;
        private System.Windows.Forms.TextBox tb_IDLaptop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_NamaLaptop;
        private System.Windows.Forms.Label label4;
    }
}