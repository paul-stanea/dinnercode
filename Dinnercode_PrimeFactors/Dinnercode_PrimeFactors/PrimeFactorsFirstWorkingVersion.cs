using System.Collections.Generic;

namespace Dinnercode_PrimeFactors
{
    public class PrimeFactorsFirstWorkingVersion
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