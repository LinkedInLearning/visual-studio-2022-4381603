using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassViewSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface Person
    {
        string Name { get; set; }

        int Id { set; get; }
    }

    public class Customer : Person
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
