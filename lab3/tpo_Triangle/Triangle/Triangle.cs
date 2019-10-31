using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public static bool IsPossible(double sideA, double sideB, double sideC)
        {
            return (sideA > 0 && sideB > 0 && sideC > 0 && (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB));
        }
    }
}
