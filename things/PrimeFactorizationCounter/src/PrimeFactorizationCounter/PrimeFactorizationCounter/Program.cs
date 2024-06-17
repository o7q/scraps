using System;
using System.Collections.Generic;

namespace PrimeFactorizationCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();

            while (true)
            {
                Console.Clear();
                Console.Write("Enter Primes: (type ! to continue)\n-> ");

                string read = Console.ReadLine();
                if (read == "!")
                {
                    break;
                }

                primes.Add(int.Parse(read));
            }
            int product = 1;
            for (int i = 0; i < primes.Count; i++)
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

            Console.ReadKey();
        }

        // idk what this is
        /*private static List<int> CalculatePrimesInPrimeFactorization(int number)
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
        }*/
    }
}