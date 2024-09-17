using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.models
{
    internal class SellerSalary
    {
        // Este método calcula el salario basado en las ventas brutas.
        private const int FixedSalary = 200;
        private const double Commission = 0.09;

        // Este método calcula el salario basado en las ventas brutas.
        public int CalculateSalary(int grossSales)
        {
            return (int)(FixedSalary + (grossSales * Commission));
        }
    }
}
