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
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void Lbhora_Click(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("hh:mm:ss dddd MMMM yyy ");
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Comida ToComida = new Comida();
            this.Hide();
            ToComida.Show();
        }
    }
}
