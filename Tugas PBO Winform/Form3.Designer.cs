namespace Tugas_PBO_Winform
{
    partial class DeleteLapop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_DeleteLaptop = new System.Windows.Forms.Button();
            this.tb_IDLaptop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.bt_DeleteLaptop);
            this.panel1.Controls.Add(this.tb_IDLaptop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 217);
            this.panel1.TabIndex = 0;
            // 
            // bt_DeleteLaptop
            // 
            this.bt_DeleteLaptop.Location = new System.Drawing.Point(129, 121);
            this.bt_DeleteLaptop.Name = "bt_DeleteLaptop";
            this.bt_DeleteLaptop.Size = new System.Drawing.Size(113, 41);
            this.bt_DeleteLaptop.TabIndex = 25;
            this.bt_DeleteLaptop.Text = "Delete";
            this.bt_DeleteLaptop.UseVisualStyleBackColor = true;
            this.bt_DeleteLaptop.Click += new System.EventHandler(this.bt_DeleteLaptop_Click);
            // 
            // tb_IDLaptop
            // 
            this.tb_IDLaptop.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.tb_IDLaptop.Location = new System.Drawing.Point(61, 74);
            this.tb_IDLaptop.Name = "tb_IDLaptop";
            this.tb_IDLaptop.Size = new System.Drawing.Size(263, 28);
            this.tb_IDLaptop.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F);
            this.label4.Location = new System.Drawing.Point(143, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID Laptop";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteLapop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 217);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteLapop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Laptop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_IDLaptop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_DeleteLaptop;
    }
}