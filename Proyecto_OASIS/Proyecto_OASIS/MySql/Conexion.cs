﻿using System;
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
            MySqlConnection conexion = new MySqlConnection("server = localhost; database=snack_db; Uid=root; pwd = ;");
            conexion.Open();
            return conexion;
        }
    }
}
