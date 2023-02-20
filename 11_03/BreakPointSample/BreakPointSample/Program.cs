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
            string WORD = string.Empty;

            WORD = "#";

            WORD = SampleMethod(WORD);
        }

        private static string SampleMethod(string word)
        {
            for (int i = 0; i < 10; i++)
            {
                word = word + i.ToString();
                Console.WriteLine(word);
            }

            return word;
        }
    }
}
