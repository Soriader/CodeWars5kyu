using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars5kyu
{
	public class BirdMountainTask
	{
		public static int PeakHeight(char[][] mountain)
		{
			if (!mountain.Where(x => x.Contains('^')).Any()) return 0;
			if (mountain.Count() <= 2) return 1;
			var reduced = new char[mountain.Count() - 2][];
			for (int i = 1; i < mountain.Count() - 1; i++)
			{
				var reducedInner = new char[mountain[i].Count() - 2];
				for (int j = 1; j < mountain[i].Count() - 1; j++)
					reducedInner[j - 1] = new[] { mountain[i - 1][j], mountain[i + 1][j], mountain[i][j], mountain[i][j - 1], mountain[i][j + 1] }
					.Contains(' ') ? ' ' : '^';
				reduced[i - 1] = reducedInner;
			}
			return 1 + PeakHeight(reduced);
		}
	}
}
//https://www.codewars.com/kata/5c09ccc9b48e912946000157/train/csharp