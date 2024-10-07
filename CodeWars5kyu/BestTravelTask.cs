using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class BestTravelTask
    {
		public static int? ChooseBestSum(int t, int k, List<int> ls)
		{
			if (t <= 0 || k < 1 || ls == null || ls.Count < k)
			{
				return null;
			}

			var combinations = GetCombinations(ls, k);
			var possibleSums = combinations
				.Select(combination => combination.Sum())
				.Where(sum => sum <= t)
				.ToList();

			return possibleSums.Any() ? possibleSums.Max() : (int?)null;
		}

		private static IEnumerable<List<int>> GetCombinations(List<int> ls, int k)
		{
			if (k == 0)
			{
				yield return new List<int>();
			}
			else
			{
				for (int i = 0; i < ls.Count; i++)
				{
					var element = ls[i];
					var remaining = ls.Skip(i + 1).ToList();
					foreach (var combination in GetCombinations(remaining, k - 1))
					{
						combination.Insert(0, element);
						yield return combination;
					}
				}
			}
		}
	}
}
//https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa/train/csharp