using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //Z2
    class Product : IShipable
    {
        private double weight;
        private double price;
        private string description;
        public Product(double weight,string description, double price)
        {
            this.description = description;
            this.price = price;
        }
        public double Price { get { return this.price; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
        public double Weight { get { return this.weight; } }
    }
}
