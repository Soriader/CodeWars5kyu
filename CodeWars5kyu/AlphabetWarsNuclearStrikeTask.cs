using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class AlphabetWarsNuclearStrikeTask
	{
		public static string AlphabetWar(string b)
		{
			if (!b.Contains('#')) return string.Concat(b.Where(char.IsLetter));

			var result = b.Split('[', ']');

			var nukeCounts = result.Select(s => s.Count(c => c == '#')).ToArray();

			for (int i = 0; i < result.Length; i++)
			{
				if (i % 2 == 0 || nukeCounts[i - 1] + nukeCounts[i + 1] > 1)
				{
					result[i] = string.Empty;
				}
			}

			return string.Concat(result);
		}
	}
}
//https://www.codewars.com/kata/59437bd7d8c9438fb5000004/train/csharp