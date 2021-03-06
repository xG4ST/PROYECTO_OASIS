﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Proyecto_OASIS.MySql
{
    class Connection
    {
        private static string Server = "localhost";
        private static string Database = "snack_db";
        private static string User = "root";
        private static string Password = "123456";

        private static string StrConnection = $"server={Server}; database={Database}; Uid={User}; pwd={Password}";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn;
            try
            {
                conn = new MySqlConnection(StrConnection);
                conn.Open();
                Console.WriteLine("Conectado con exito");
            }
            catch (Exception e)
            {
                conn = null;
                Console.WriteLine(e);
            }

            return conn;
        }

        public static void Close(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
