using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class FindTheSmallestTask
	{
		public static long[] Smallest(long n)
		{
			string numStr = n.ToString();
			int len = numStr.Length;
			long minValue = n;
			int fromIndex = 0, toIndex = 0;

			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					if (i == j) continue;

					string modifiedStr = MoveDigit(numStr, i, j);
					long modifiedValue = long.Parse(modifiedStr);

					if (modifiedValue < minValue)
					{
						minValue = modifiedValue;
						fromIndex = i;
						toIndex = j;
					}
				}
			}

			return new long[] { minValue, fromIndex, toIndex };
		}

		private static string MoveDigit(string numStr, int fromIndex, int toIndex)
		{
			char digit = numStr[fromIndex];
			string result = numStr.Remove(fromIndex, 1).Insert(toIndex, digit.ToString());
			return result;
		}
	}
}
//https://www.codewars.com/kata/573992c724fc289553000e95/train/csharp