using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class PlayWithTwoStringsTask
	{
		public string WorkOnStrings(string a, string b)
		{
			foreach (char charB in b)
			{
				a = SwapCase(a, charB);
			}

			foreach (char charA in a)
			{
				b = SwapCase(b, charA);
			}

			return a + b;
		}

		private string SwapCase(string input, char c)
		{
			char lower = char.ToLower(c);
			char upper = char.ToUpper(c);

			return string.Concat(input.Select(x => x == lower ? upper : x == upper ? lower : x));
		}
	}
}
//https://www.codewars.com/kata/56c30ad8585d9ab99b000c54/train/csharp