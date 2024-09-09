using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars5kyu
{
	public class ClosestAndSmallestTask
	{
		public static int[][] Closest(string strng)
		{
			if (string.IsNullOrWhiteSpace(strng)) 
			{
				return new int[][] { }; 
			}  

			List<int[]> numberData = new List<int[]>();

			var separateNumbers = strng.Split(' ');

			for (int i = 0; i < separateNumbers.Length; i++)
			{
				int weight = separateNumbers[i].ToCharArray().Sum(c => c - '0'); 
				numberData.Add(new int[] { weight, i, int.Parse(separateNumbers[i]) });
			}

			numberData.Sort((a, b) =>
			{
				int cmp = a[0].CompareTo(b[0]); 
				if (cmp == 0) cmp = a[1].CompareTo(b[1]);  
				return cmp;
			});

			int minDiff = int.MaxValue;
			int[] result1 = null;
			int[] result2 = null;

			for (int i = 1; i < numberData.Count; i++)
			{
				int diff = numberData[i][0] - numberData[i - 1][0];
				if (diff < minDiff)
				{
					minDiff = diff;
					result1 = numberData[i - 1];
					result2 = numberData[i];
				}
			}

			return new int[][] { result1, result2 };
		}
	}
}
//https://www.codewars.com/kata/5868b2de442e3fb2bb000119/train/csharp