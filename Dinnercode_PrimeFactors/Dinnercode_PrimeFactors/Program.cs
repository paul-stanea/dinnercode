using System;

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
}
