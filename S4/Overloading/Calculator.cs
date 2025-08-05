using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4.Overloading
{
    internal static class Calculator
    {
        public static int Add(int A , int B)
        {
            return A + B;
        }
        public static int Add(int A , int B , int C)
        {
            return A + B + C;
        }
        public static double Add(double A, double B)
        {
            return A + B;
        }

    }
}
