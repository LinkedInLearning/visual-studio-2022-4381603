using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTipsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;

            a = 10;

            List<string> list = new List<string>() {"a", "b", "c", "d" };

            list[2] = "e";

            a = 6;
        }
    }
}
