﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string user = user_textbox.Text;
            string password = password_textbox.Text;

            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = snack_db; Uid = root; pwd = 2000;");
            conexion.Open();

            MySqlCommand login = new MySqlCommand();
            login.CommandText = "SELECT * FROM user WHERE account_user = @user AND password_user = @password";
            login.Parameters.AddWithValue("@user", user);
            login.Parameters.AddWithValue("@password", password);
            login.Connection = conexion;

            MySqlDataReader leer = login.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Bienvenido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu ToMenu = new Menu();
                this.Hide();
                ToMenu.Show();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexion.Close();
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            Registro ToRegistro = new Registro();
            this.Hide();
            ToRegistro.Show();
        }
    }
}