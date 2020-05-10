using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_OASIS
{
    public partial class Ya_eres_cliente : Form
    {
        public Ya_eres_cliente()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
           
            Ya_eres_cliente ToMenu = new Ya_eres_cliente();
            this.Hide();
            ToMenu.Show();
        }
    }
}
