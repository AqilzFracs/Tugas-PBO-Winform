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
    public partial class DeleteLapop : Form
    {
        public DeleteLapop()
        {
            InitializeComponent();
        }

        private void bt_DeleteLaptop_Click(object sender, EventArgs e)
        {
            new DBHelpers().Execute($"Delete from laptop where id_laptop = '{tb_IDLaptop.Text}'");
            this.Close();
        }
    }
}
