using CodeWars5kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class FactorialDecompositionTask
    {
        public static string Decomp(int n)
        {
            List<int> primes = SieveOfEratosthenes(n);

            Dictionary<int, int> primeFactors = new Dictionary<int, int>();

            foreach (var prime in primes)
            {
                int count = 0;
                int power = prime;
                while (power <= n)
                {
                    count += n / power;
                    power *= prime;
                }
                primeFactors[prime] = count;
            }

            List<string> result = new List<string>();
            foreach (var prime in primeFactors)
            {
                if (prime.Value == 1)
                    result.Add($"{prime.Key}");
                else
                    result.Add($"{prime.Key}^{prime.Value}");
            }

            return string.Join(" * ", result);
        }

        private static List<int> SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
//https://www.codewars.com/kata/5a045fee46d843effa000070/train/csharp