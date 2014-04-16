using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactorizer
    {
        public IList<int> Factorize(int nunber)
        {
            var primes = new List<int>();

            int candidate = 2;
            while (nunber > 1)
            {
                while (nunber % candidate == 0)
                {
                    primes.Add(candidate);
                    nunber /= candidate;
                }
                candidate++;
            }

            return primes;
        }
    }
}