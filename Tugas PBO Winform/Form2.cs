using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_PBO_Winform
{
    public partial class UpdateLaptop : Form
    {
        public UpdateLaptop()
        {
            InitializeComponent();
        }

        private void bt_Insert_Laptop_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"UPDATE laptop SET nama_laptop = '{tb_NamaLaptop.Text}', harga_laptop = {tb_HargaLaptop.Text}, stok = {tb_StokLaptop.Text} where id_laptop = {tb_IDLaptop.Text}");
            this.Close();
        }

        private void tb_IDLaptop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
