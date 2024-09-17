using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.models
{
    internal class SitNums
    {
        private bool[] Sits = new bool[10];

        public int assignSit(int section)
        {
            int start = (section == 1) ? 0 : 5;
            int end = (section == 1) ? 5 : 10;

            for (int i = start; i <= end; i++)
            {
                if (!Sits[i])
                {
                    Sits[i] = true;
                    return i + 1;
                }
            }
            return -1;
        }

        public bool IstFull(int section)
        {
            int start = (section == 1) ? 0 : 5;
            int end = (section == 1) ? 4 : 9;

            for (int i = start; i <= end; i++)
            {
                if (!Sits[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
