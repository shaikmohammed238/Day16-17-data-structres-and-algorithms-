using System;

namespace PrimeNUmDemo
{    //Take a range of 0 - 10 Numbers and find the Prime numbers in that range.
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, low, high;
            low = 0;
            high = 10;

            Console.WriteLine("The Prime numbers between {0} and {1} are: \n", low, high);

            for (num = low; num <= high; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                {
                    Console.WriteLine("{0}", num);
                }
            }
            Console.WriteLine("\n");
        }
    }
}