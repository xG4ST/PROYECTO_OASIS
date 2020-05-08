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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Login ToLogin = new Login();
            this.Hide();
            ToLogin.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            userAccount newAccount = new userAccount();
            nuevaCuenta.nom_med = Nombre_TextBox.Text.Trim();
            nuevaCuenta.especialidad_med = Especialidad_TextBox.Text.Trim();
            nuevaCuenta.correo_med = Correo_TextBox.Text.Trim();
            nuevaCuenta.contraseña_med = Contraseña_TextBox.Text.Trim();

            if (string.IsNullOrEmpty(Nombre_TextBox.Text) || string.IsNullOrEmpty(Especialidad_TextBox.Text) || string.IsNullOrEmpty(Correo_TextBox.Text) || string.IsNullOrEmpty(Contraseña_TextBox.Text))
            {
                MessageBox.Show("Los campos no pueden quedar vacios", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int resultado = RegistrarCuentaMed.agregar(nuevaCuenta);
                if (resultado > 0)
                {
                    MessageBox.Show("Usuario Registrado con Exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Log Form1 = new Log();
                    this.Hide();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
