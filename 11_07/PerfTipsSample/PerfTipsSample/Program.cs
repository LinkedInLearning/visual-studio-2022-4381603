using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfTipsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 10;

            SomeMethod();
        }

        private static void SomeMethod()
        {
            int count = 0;

            for (int i = 0; i < 100000000; i++)
            {
                count++;
            }
        }
    }
}
