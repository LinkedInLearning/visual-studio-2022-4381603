using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSample
{
    internal class Program
    {
        private const double PI = 3.14;

        static void Main(string[] args)
        {
            double abc = 4 * PI;
            SampleMethod(abc);
        }

        private static void SampleMethod(double abc)
        {
            double b = 2 * PI;

            double c = abc * b;
        }
    }
}
