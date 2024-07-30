using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class WhatIsAPerfectPowerAnywayTask
	{
		public static (int, int)? IsPerfectPower(int n)
		{
			if (n < 2) return null; 

			for (int m = 2; m <= Math.Sqrt(n); m++)
			{
				int k = 2;
				double power = Math.Pow(m, k);

				while (power <= n)
				{
					if (power == n)
					{
						return (m, k);
					}

					k++;
					power = Math.Pow(m, k);
				}
			}

			return null;
		}
	}
}
//https://www.codewars.com/kata/54d4c8b08776e4ad92000835/train/csharp