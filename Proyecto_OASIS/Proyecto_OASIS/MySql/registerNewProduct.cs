using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_OASIS.MySql
{
    class registerNewProduct
    {
        public static int agregar(product add)
        {
            int devolver = 0;
            MySqlCommand comand = new MySqlCommand(String.Format("INSERT INTO product(name_prod, des_prod, price_prod, purchasePrice_prod, stock_prod) value('{0}', '{1}', '{3}', '{4}', '{5}')",
                add.name_prod, add.des_prod, add.price_prod, add.purchasePrice_prod, add.stock_prod), Conexion.obtainConexion());
            devolver = comand.ExecuteNonQuery();
            return devolver;
        }
    }
}
