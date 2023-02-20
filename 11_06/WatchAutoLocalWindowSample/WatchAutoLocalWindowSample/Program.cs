using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WatchAutoLocalWindowSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 3;

            int result = AddMethod(a, b);
        }

        private static int AddMethod(int inA, int inB)
        {
            return inA + inB;
        }
    }
}
