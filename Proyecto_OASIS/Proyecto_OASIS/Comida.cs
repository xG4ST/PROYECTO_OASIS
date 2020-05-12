using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_OASIS
{
    public partial class Comida : Form
    {
       // MySqlConnection conexion = new MySqlConnection("server = localhost; database=snack_db; Uid=root; pwd = ;");




        public Comida()
        {
            InitializeComponent();
            cargar_datos();
        }

        public void cargar_datos()
        {
          //conexion.Open();
          //   MySqlCommand cm = new MySqlCommand"SELECT id_product,name_product FROM product", conexion);
          //  //SELECT * FROM snack_db.product, name_product
          //  //snack_db.product
          //  //SELECT id_product,name_product FROM product
          //  MySqlDataAdapter da = new MySqlDataAdapter(cm);
          //  DataTable dt = new DataTable();
          //  da.Fill(dt);
          //  conexion.Close();

            //DataRow fila = dt.NewRow(); ;
            //fila["name_product"] = "Seleccionar caomida";
            //dt.Rows.InsertAt(fila, 0);

            //comboBox1.ValueMember = "name_product";
            //comboBox1.DisplayMember = "id_product";
            //comboBox1.DataSource = dt;
        }

        //public void carga_des_product(String name_product)
        //{
        //    conexion.Open();
        //    MySqlCommand cm = new MySqlCommand("SELECT id_product,name_product FROM product WHERE ", conexion);
        //    cm.Parameters.A ddWithValue("",);
        //    MySqlDataAdapter da = new MySqlDataAdapter(cm);
        //    DataTable d = new DataTable();
        //    da.Fill(dt);


        //    DataRow fila = dt.NewRow(); ;
        //    dr["Aqui va lo que quieres seleccionar"] = "La seleccion";
        //    dt.Rows.InsertAt(dr, 0);

        //    comboBox2.ValueMember = "";
        //    comboBox2.DisplayMember = "No";
        //    comboBox2.DataSource = dt;
        //}


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
