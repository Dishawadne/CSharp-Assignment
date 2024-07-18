using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DisplayTable
    {
        public void dispaly()
        {
            //for loop
            Console.WriteLine("Using For");
            Console.WriteLine("Enter Table of Number  :");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }

               Console.WriteLine("using do while");

           
            int j = 1;
            do
            {
                Console.WriteLine(num * j);
                j++;
            }
            while (j <= 10);


            Console.WriteLine("using while loop");

           
            int k = 1;
            while (k <= 10)
            {
                Console.WriteLine(num * k);
                k++;
                   }

            }
    }
}
