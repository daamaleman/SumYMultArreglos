using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.models
{
    internal class SellerSalary
    {
        private const int FixedSalary = 200;
        private const double Commission = 0.09;

        public int CalculateSalary(int grossSales)
        {
            return (int)(FixedSalary + (grossSales * Commission));
        }
    }
}
