using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_OASIS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void BunifuTileButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ya_eres_cliente ToMenu = new Ya_eres_cliente();
            this.Hide();
            ToMenu.Show();
      
        }

        
    }
}
