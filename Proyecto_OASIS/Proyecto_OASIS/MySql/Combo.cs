using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS.MySql
{
    class Combo
    {
        MySqlConnection con = new MySqlConnection("server = localhost; database=snack_db; Uid=root; pwd = ;");
 
        public void llenarCombo(ComboBox combo1)
        {

            MySqlCommand cm = new MySqlCommand("product,",con);

            cm.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable ();

            da.Fill(dt);
            combo1.ValueMember = "name_product";
            combo1.DisplayMember = "des_product";
            combo1.DataSource = dt;
        }



    }
}
