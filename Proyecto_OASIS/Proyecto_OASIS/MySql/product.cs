using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_OASIS.MySql
{
    class product
    {
        public int id_prod { get; set; }
        public string name_prod { get; set; }
        public string des_prod { get; set; }
        public float price_prod { get; set; }
        public float purchasePrice_prod { get; set; }
        public int stock_prod { get; set; }

        public product() { }
        public product(int id, string name, string des, float price, float purchase, int stock)
        {
            this.id_prod = id;
            this.name_prod = name;
            this.des_prod = des;
            this.price_prod = price;
            this.purchasePrice_prod = purchase;
            this.stock_prod = stock;
        }
    }
}
