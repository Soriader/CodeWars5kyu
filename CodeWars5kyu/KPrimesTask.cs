using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class KPrimesTask
	{
		public static int Puzzle(int s)
		{
			var primes1 = CountKprimes(1, 2, s);
			var primes3 = CountKprimes(3, 2, s);
			var primes7 = CountKprimes(7, 2, s);

			int countSolutions = 0;

			foreach (var a in primes1)
			{
				foreach (var b in primes3)
				{
					foreach (var c in primes7)
					{
						if (a + b + c == s)
						{
							countSolutions++;
						}
					}
				}
			}

			return countSolutions;
		}

		public static long[] CountKprimes(int k, long start, long end)
		{
			List<long> kNumbers = new List<long>();

			for (long i = start; i <= end; i++)
			{
				int primeFactorCount = CountPrimeFactors(i); 
				if (primeFactorCount == k)
				{
					kNumbers.Add(i);
				}
			}

			return kNumbers.ToArray();
		}

		private static int CountPrimeFactors(long n)
		{
			int count = 0;
			for (long i = 2; i * i <= n; i++)
			{
				while (n % i == 0)
				{
					count++;
					n /= i;
				}
			}

			if (n > 1) 
			{
				count++;
			}

			return count;
		}

	}
}
//https://www.codewars.com/kata/5726f813c8dcebf5ed000a6b/train/csharp