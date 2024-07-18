using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArithmaticOp
    {
        public void ArithmaticOp1(int a, int b) {
            Console.WriteLine($"Addition of {a} and {b} is{a + b}");
            Console.WriteLine($"Subtraction of {a} and {b} is {a - b}");
            Console.WriteLine($"Product of {a} and {b} is {a * b}");
            Console.WriteLine($"Quotient of {a} and {b} is {a % b}");

        }   
    }
}
