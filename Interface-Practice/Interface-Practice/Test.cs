using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    internal class Test : Book,IBook
    {
        public int MyProperty { get; set; }
    }
}
