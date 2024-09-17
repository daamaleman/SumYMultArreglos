using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.models
{
    internal class Passenger
    {
        public string Name { get; set; }
        public int SelectNumber { get; set; }
        public string Section { get; set; }

        public Passenger(string name, int selectNumber, string section)
        {
            Name = name;
            SelectNumber = selectNumber;
            Section = section;
        }
    }
}
