﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    internal class Book : IBook
    {
        public void GetName()
        {
            Console.WriteLine("Isgendername");
        }
    }
}
