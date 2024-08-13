using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class LandPerimeterTask
	{
		public static string Calculate(string[] map)
		{
			int perimeter = 0;

			for (int i = 0; i < map.Length; i++)
			{
				for (int j = 0; j < map[i].Length; j++)
				{
					if (map[i][j] == 'X')
					{
						perimeter += 4;

						if (j < map[i].Length - 1 && map[i][j + 1] == 'X')
						{
							perimeter -= 2;
						}

						if (i < map.Length - 1 && map[i + 1][j] == 'X')
						{
							perimeter -= 2;
						}
					}
				}
			}

			return $"Total land perimeter: {perimeter}";
		}
	}
}
//https://www.codewars.com/kata/5839c48f0cf94640a20001d3/train/csharp