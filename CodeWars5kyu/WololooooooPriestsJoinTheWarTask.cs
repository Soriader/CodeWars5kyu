using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class WololooooooPriestsJoinTheWarTask
	{
		public static Dictionary<char, int> LeftSide = new Dictionary<char, int>() 
		{
			{'w', 4}, {'p', 3}, {'b', 2}, {'s', 1}
		};

		public static Dictionary<char, int> RightSide = new Dictionary<char, int>() 
		{
			{'m', 4}, {'q', 3}, {'d', 2}, {'z', 1}
		};
		public static string AlphabetWar(string fight)
		{
			int leftPower = 0;
			int rightPower = 0;
			string priestResult = "";


			for (int i = 0; i < fight.Length; i++)
			{
				bool hasLeftNeighbor = i - 1 >= 0;
				bool hasRightNeighbor = i + 1 < fight.Length;

				if(hasLeftNeighbor && fight[i - 1] == 'j' && hasRightNeighbor && fight[i + 1] == 't' || hasLeftNeighbor && fight[i - 1] == 't' && hasRightNeighbor && fight[i + 1] == 'j')
				{
					priestResult += fight[i];
				}
				else if (hasLeftNeighbor && fight[i - 1] == 'j' && LeftSide.ContainsKey(fight[i])|| hasRightNeighbor && fight[i + 1] == 'j' && LeftSide.ContainsKey(fight[i]))
				{
					priestResult += ReplaceMachine(fight[i]);
				}
				else if ((hasLeftNeighbor && fight[i - 1] == 't') && RightSide.ContainsKey(fight[i]) || (hasRightNeighbor && fight[i + 1] == 't') && RightSide.ContainsKey(fight[i]))
				{
					priestResult += ReplaceMachine(fight[i]);
				}
				else
				{
					priestResult += fight[i];
				}
			}


			for (int i = 0; i < priestResult.Length; i++)
			{

				if (LeftSide.ContainsKey(priestResult[i]))
				{
					leftPower += LeftSide.GetValueOrDefault(priestResult[i]);
				}

				if (RightSide.ContainsKey(priestResult[i]))
				{
					rightPower += RightSide.GetValueOrDefault(priestResult[i]);
				}
			}

			if (leftPower > rightPower)
			{
				return "Left side wins!";
			}
			else if(leftPower < rightPower)
			{
				return "Right side wins!";
			}

			return "Let's fight again!";
		}

		private static char ReplaceMachine(char letter)
		{
			if (LeftSide.ContainsKey(letter))
			{
				int index = LeftSide[letter];
				return RightSide.FirstOrDefault(x => x.Value == index).Key;
			}

			if (RightSide.ContainsKey(letter))
			{
				int index = RightSide[letter];
				return LeftSide.FirstOrDefault(x => x.Value == index).Key;
			}

			return letter;
		}
	}
}
//https://www.codewars.com/kata/59473c0a952ac9b463000064/train/csharp