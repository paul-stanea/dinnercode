using System.Collections.Generic;

namespace Dinnercode_PrimeFactors
{
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
}