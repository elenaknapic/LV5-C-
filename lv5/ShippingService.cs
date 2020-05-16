using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5
{
    //Z2
    class ShippingService
    {
        private double cijenaMase = 5.99;

        public double CijenaDostavePaketa(IShipable item)
        {
            double cijena;

            cijena = cijenaMase + item.Weight;

            return cijena;
        }
    }
}
