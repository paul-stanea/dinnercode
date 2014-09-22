using System;
using System.Collections.Generic;

namespace Dinnercode_PrimeFactors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            PrimeFactors.Generate(n).ForEach(i => Console.Write("{0}\t", i));
            Console.ReadKey();
        }
    }

    public class PrimeFactors
    {
        public static List<int> Generate(int n)
        {
            List<int> factors = new List<int>();
            int primeFactor = 2;
            while (n >= primeFactor)
            {
                if (n % primeFactor == 0)
                {
                    factors.Add(primeFactor);
                    n = n / primeFactor;
                }
                else
                {
                    primeFactor++;
                }
            }

            return factors;
        }
    }


    public class PrimeFactors_FirstWorkingVersion
    {
        public static List<int> Generate(int n)
        {
            List<int> factors = new List<int>();
            int primeFactor = 2;
            while (n > 2)
            {
                for (int i = 2; i < primeFactor / 2; i++)
                {
                    if (primeFactor % i == 0)
                    {
                        break;
                    }
                }

                if (n % primeFactor == 0)
                {
                    factors.Add(primeFactor);
                    n = n / primeFactor;
                }
                primeFactor++;
            }

            return factors;
        }
    }
}
