using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPointSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            word = "#";

            word = SampleMethod(word);
        }

        private static int count = 3;

        private static string SampleMethod(string word)
        {
            for (int i = 0; i < count; i++)
            {
                word = word + i.ToString();
                Console.WriteLine(word);
            }

            return word;
        }
    }
}
