using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.models
{
    internal class Sales
    {
        public int Seller { get; set; }
        public int Product { get; set; }
        public float SalesValue { get; set; }

        public Sales (int seller, int product, float salesValue)
        {
            Seller = seller;
            Product = product;
            SalesValue = salesValue;
        }

    }
}
