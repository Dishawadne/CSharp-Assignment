using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class DispalyEven
    {
        //using for loop
        public void Dispaly()

        {
            Console.WriteLine("Using For-loop");
            for (int k= 0; k < 10; k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }



            //using while


            Console.WriteLine("Using While loop");

            int i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }



            Console.WriteLine("Using Dowhile-loop");
            //using Do-While

            int j = 0;
            do
            {
                if ((j % 2) == 0) { Console.WriteLine(j); }
                j++;
            } while (j< 10);

        }
    }
}
