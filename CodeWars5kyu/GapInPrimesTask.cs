using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class GapInPrimesTask
	{
		public static long[] Gap(int g, long m, long n)
		{
			long previousPrime = 0;

			for (long i = m; i <= n; i++)
			{
				if (IsPrime(i))
				{
					if (previousPrime != 0 && i - previousPrime == g)
					{
						return new long[] { previousPrime, i };
					}
					previousPrime = i;
				}
			}

			return null; 
		}

		private static bool IsPrime(long number)
		{
			if (number <= 1) return false;
			if (number == 2) return true;
			if (number % 2 == 0) return false;

			for (long i = 3; i * i <= number; i += 2)
			{
				if (number % i == 0) return false;
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/561e9c843a2ef5a40c0000a4/train/csharp