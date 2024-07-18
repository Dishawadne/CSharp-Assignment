using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ArithmaticOp2
    {
        public void PerformOp()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Choose an operation:");
            Console.WriteLine("0: Addition");
            Console.WriteLine("1: Subtraction");
            Console.WriteLine("2: Multiplication");
            Console.WriteLine("3: Division");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Add(num1, num2);
                    break;
                case 1:
                    Subtract(num1, num2);
                    break;
                case 2:
                    Multiply(num1, num2);
                    break;
                case 3:
                    quotient(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        private void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition result: {result}");
        }

        private void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtraction result: {result}");
        }

        private void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication result: {result}");
        }
         private void quotient(int a, int b) {
            int result = a / b;
            Console.WriteLine($"Division result: {result}");

    }
}
}
