using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDefineSample
{
    internal class Sample2
    {
        internal Sample2()
        {
            ClassDefineSample.Another.Sample sample = new ClassDefineSample.Another.Sample();
        }
    }
}
