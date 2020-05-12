using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Proyecto_OASIS
{
    public partial class Comida : Form
    {
      MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database= snack_db; Uid = root; pwd = 2000;");

        public Comida()
        {
            InitializeComponent();
            cargar_datos();
        }

        public void cargar_datos()
        {
            //SELECT* FROM snack_db.product, name_product
            //snack_db.product
            //SELECT id_product,name_product FROM product

            string product = "Alita";

            conexion.Open();
            MySqlCommand cm = new MySqlCommand("SELECT id_prod, name_prod FROM product WHERE name_prod = @product", conexion);
            cm.Parameters.AddWithValue("@product", product);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["name_prod"] = "Selecciona un producto";
            dt.Rows.InsertAt(fila, 0);

            comboBox1.ValueMember = "id_prod";
            comboBox1.DisplayMember = "name_prod";
            comboBox1.DataSource = dt;
        }

        public void carga_des_product(String name_product)
        {
            //conexion.Open();
            //MySqlCommand cm = new MySqlCommand("SELECT id_product, name_product, des_product FROM product WHERE name_product = Alita", conexion);



            //cm.Parameters.AddWithValue("des_prod", );
            //MySqlDataAdapter da = new MySqlDataAdapter(cm);
            //DataTable cm = new DataTable();
            //da.Fill(dt);
            //return dt;

            //DataRow fila = dt.NewRow(); ;
            //dr["Aqui va lo que quieres seleccionar"] = "La seleccion";
            //dt.Rows.InsertAt(dr, 0);

            //comboBox2.ValueMember = "";
            //comboBox2.DisplayMember = "No";
            //comboBox2.DataSource = dt;
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Comida_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (comboBox1.SelectedValue.ToString() != null)
            //{
            //  String name_prod = comboBox1.SelectedValue.ToString();
            // cargar_datos(price_product)
            // }






            //conexion.Open();
            //MySqlCommand cm = new MySqlCommand("SELECT id_product, name_product, des_product FROM product WHERE name_product = Alita");
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(cm);
            //DataSet ds = new DataSet();
            //adaptador.Fill(ds);
            


            //MySqlDataReader leer = cm.ExecuteReader();
            //if (leer.Read())
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Usuario o Contraseña incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    conexion.Close();
            //}



        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Confirmacion_de_pedido ToMenu = new Confirmacion_de_pedido();
            this.Hide();
            ToMenu.Show();
        }
    }
}
