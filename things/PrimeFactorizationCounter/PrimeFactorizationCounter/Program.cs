using System;
using System.Collections.Generic;

namespace PrimeFactorizationCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes = { 2, 5, 7, 11 };
            int product = 1;
            for (int i = 0; i < primes.Length; i++)
            {
                product *= primes[i];
            }

            int count = 0;
            for (int i = 1; i <= product; i++)
            {
                if (product % i == 0)
                {
                    count++;
                    Console.WriteLine(i.ToString() + " * " + (product / i).ToString());
                }
            }

            Console.WriteLine("Ways product can be written: " + count / 2);

            //Console.WriteLine(product.ToString());

            //int number = 42;
            //List<int> factors = CalculatePrimesInPrimeFactorization(number);

/*            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

/*            foreach (int i in factors)
            {
                Console.WriteLine(i);
            }*/

            Console.ReadKey();
        }

        private static List<int> CalculatePrimesInPrimeFactorization(int number)
        {
            List<int> factors = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                        if (count > 2)
                        {
                            break;
                        }
                    }
                    if (count == 2)
                    {
                        factors.Add(i);
                    }
                }
            }

            return factors;
        }
    }
}