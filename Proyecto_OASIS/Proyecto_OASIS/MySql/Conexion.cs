using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Proyecto_OASIS.MySql
{
    class Conexion
    {
        public static MySqlConnection obtainConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server = 127.0.0.1; database = snack_db; Uid = root; pwd = 2000;");
            conexion.Open();
            return conexion;
        }
    }
}
