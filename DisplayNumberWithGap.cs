﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayNumberWithGap
    {
        public void displayNumber()
        {
            for (int i = 100; i >= 5; i -= 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
