using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramSample
{
    internal class Sample : ISample
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string SampleMethod(string str)
        {
            return "OK";
        }
    }

    public interface ISample
    {

    }
}
