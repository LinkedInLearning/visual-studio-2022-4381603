using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsole
{
    internal class Program
    {
        #region プロパティ
        public string SampleString { get; set; }

        public int MyProperty { get; set; }
        #endregion

        /// <summary>
        /// コメントや中括弧は折りたたむことができます
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int length = 4;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
