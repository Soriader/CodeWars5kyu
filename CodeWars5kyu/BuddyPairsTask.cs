using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class BuddyPairsTask
	{
		public static string Buddy(long start, long limit)
		{
			for (long n = start; n <= limit; n++)
			{
				long sumN = GetSumOfDivisors(n);
				long m = sumN - 1;

				if (m > n && GetSumOfDivisors(m) == n + 1)
				{
					return $"({n} {m})";
				}
			}

			return "Nothing";
		}

		private static long GetSumOfDivisors(long number)
		{
			long sum = 1;
			for (long i = 2; i * i <= number; i++)
			{
				if (number % i == 0)
				{
					if (i * i == number)
					{
						sum += i;
					}
					else
					{
						sum += i + (number / i);
					}
				}
			}
			return sum;
		}
	}
}
//https://www.codewars.com/kata/59ccf051dcc4050f7800008f/train/csharp
