using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class SimpleFractionToMixedNumberConverterTask
	{
		public static string MixedFraction(string s)
		{
			var check = s.Split("/").Select(x => int.Parse(x)).ToList();

			int meter = check[0];
			int denominator = check[1];

			if (denominator == 0)
			{
				throw new DivideByZeroException();
			}

			if (meter == 0)
			{
				return "0";
			}

			bool negative = meter < 0 ^ denominator < 0;

			meter = Math.Abs(meter);
			denominator = Math.Abs(denominator);

			int full = meter / denominator;
			int modulo = meter % denominator;

			if (modulo == 0)
			{
				return (negative ? "-" : "") + full.ToString();
			}

			int gcd = GCD(modulo, denominator);
			modulo /= gcd;
			denominator /= gcd;

			if (full == 0)
			{
				return (negative ? "-" : "") + $"{modulo}/{denominator}";
			}

			return (negative ? "-" : "") + $"{full} {modulo}/{denominator}";
		}

		private static int GCD(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

	}
}

//https://www.codewars.com/kata/556b85b433fb5e899200003f/train/csharp