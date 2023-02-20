using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStyleSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IPerson
    {
        string Name { get; set; }

        int Age { get; set; }
    }

    public class Customer : IPerson
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }

}
