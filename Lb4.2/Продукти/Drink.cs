using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb4._2.Продукти
{
    internal class Drink : Products
    {
        public DateTime Expiration_date { get; set; }
        public Drink(string name, double price, DateTime date_of_creation, DateTime expiration_date) : base(name, price, date_of_creation)
        {
            Expiration_date = expiration_date;
        }
        public bool ProductIsExpired
        {
            get { return Expiration_date < DateTime.Now; }
        }
    }
}
