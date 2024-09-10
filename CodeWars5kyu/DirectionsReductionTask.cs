using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class DirectionsReductionTask
	{
		public static string[] DirReduc(string[] arr)
		{
			Stack<string> stack = new Stack<string>();

			foreach (string dir in arr)
			{
				if (stack.Count > 0 && IsOpposite(dir, stack.Peek()))
				{
					stack.Pop();
				}
				else 
				{
					stack.Push(dir);
				}
			}

			string[] result = stack.ToArray();
			Array.Reverse(result);

			return result;
		}

		private static bool IsOpposite(string dir1, string dir2)
		{
			return (dir1 == "NORTH" && dir2 == "SOUTH") ||
				   (dir1 == "SOUTH" && dir2 == "NORTH") ||
				   (dir1 == "EAST" && dir2 == "WEST") ||
				   (dir1 == "WEST" && dir2 == "EAST");
		}
	}
}
//https://www.codewars.com/kata/550f22f4d758534c1100025a/train/csharp