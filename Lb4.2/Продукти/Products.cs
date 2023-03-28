using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2.Продукти
{
    internal abstract class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Date_of_creation { get; set; }
        public Products(string name, double price, DateTime date_of_creation)
        {
            Name = name;
            Price = price;
            Date_of_creation = date_of_creation;
        }
    }
}
