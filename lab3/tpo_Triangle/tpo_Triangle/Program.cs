using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpo_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyTriangle
    {
        public static bool isTriangle(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0 && (a + b > c) && (b + c > a) && (c + a > b));
        }
    }
}
