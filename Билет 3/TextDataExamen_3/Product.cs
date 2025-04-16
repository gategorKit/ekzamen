using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataExamen_3
{
    public class Product
    {
        public string name { get; set; }
        public int amount { get; set; }
        public double price { get; set; }
        public double sale {  get; set; }
        public double total { get; }
        public double pureSale { get; }
        public Product(string name, int amount, double price, double sale)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
            this.sale = sale;
            this.pureSale = price * amount * (sale / 100);
            this.total = price * amount - pureSale;
        }
    }
}
