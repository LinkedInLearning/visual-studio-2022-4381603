using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickActionSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = SampleMethod();

            MyClass class1 = new MyClass();
        }

        private static int SampleMethod()
        {
            throw new NotImplementedException();
        }
    }

    internal class MyClass
    {
        public MyClass()
        {
        }
    }
}
