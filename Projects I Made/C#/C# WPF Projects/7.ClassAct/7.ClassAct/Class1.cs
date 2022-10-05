using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ClassAct
{
    internal class MyClass
    {
        public int Tal { get; set; }
        public string Navn { get; set; }

        public MyClass()
        {
            System.Diagnostics.Debug.Write("Dette er Constructoren!");
        }
        ~MyClass()
        {
            System.Diagnostics.Debug.Write("Dette er Destructoren!");
            GC.Collect();
        }
    }
}
