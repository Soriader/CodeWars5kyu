using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class WriteOutNumbersTask
	{
		public static string Number2Words(int n)
		{
			if (n == 0) return "zero";

			int thousands = n / 1000;
			int remainder = n % 1000;

			string words = "";

			if (thousands > 0)
			{
				words += ConvertHundreds(thousands) + " thousand";
			}

			if (remainder > 0)
			{
				if (thousands > 0) words += " ";
				words += ConvertHundreds(remainder);
			}

			return words;
		}

		public static string ConvertHundreds(int number)
		{
			Dictionary<int, string> numbersName = new Dictionary<int, string>()
	{
		{0, "zero"},
		{1, "one" },
		{2, "two"},
		{3, "three"},
		{4, "four"},
		{5, "five"},
		{6, "six"},
		{7, "seven"},
		{8, "eight"},
		{9, "nine"},
		{10, "ten"},
		{11, "eleven"},
		{12, "twelve"},
		{13, "thirteen"},
		{14, "fourteen"},
		{15, "fifteen"},
		{16, "sixteen"},
		{17, "seventeen"},
		{18, "eighteen"},
		{19, "nineteen"},
		{20, "twenty"},
		{30, "thirty"},
		{40, "forty"},
		{50, "fifty"},
		{60, "sixty"},
		{70, "seventy"},
		{80, "eighty"},
		{90, "ninety"}
	};

			string result = "";

			int hundreds = number / 100;
			int remainder = number % 100;

			if (hundreds > 0)
			{
				result += numbersName[hundreds] + " hundred";
			}

			if (remainder > 0)
			{
				if (hundreds > 0) result += " ";

				if (remainder <= 20)
				{
					result += numbersName[remainder];
				}
				else
				{
					int tens = remainder / 10 * 10;
					int units = remainder % 10;

					result += numbersName[tens];
					if (units > 0)
					{
						result += "-" + numbersName[units];
					}
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/52724507b149fa120600031d/train/csharp