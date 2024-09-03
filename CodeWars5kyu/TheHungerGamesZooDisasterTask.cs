using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class TheHungerGamesZooDisasterTask
	{
		private static readonly Dictionary<string, string> eatList = new Dictionary<string, string>()
	{
		{"antelope","|grass|"},
		{"big-fish","|little-fish|"},
		{"bug","|leaves|"},
		{"bear","|big-fish|bug|chicken|cow|leaves|sheep|"},
		{"chicken","|bug|"},
		{"cow","|grass|"},
		{"fox","|chicken|sheep|"},
		{"giraffe","|leaves|"},
		{"lion","|antelope|cow|"},
		{"panda","|leaves|"},
		{"sheep","|grass|"},
	};

		public static string[] WhoEatsWho(string zoo)
		{

			//result from codewars

			if (string.IsNullOrEmpty(zoo)) return new[] { "" };
			var animals = zoo.Split(',').ToList();
			var result = new List<string>() { zoo };
			var canEat = true;
			while (canEat)
			{
				for (var i = 0; i < animals.Count; i++)
				{
					if (eatList.ContainsKey(animals[i]))
					{
						if (i > 0 && eatList[animals[i]].Contains($"|{animals[i - 1]}|"))
						{
							result.Add($"{animals[i]} eats {animals[i - 1]}");
							animals.RemoveAt(i - 1);
							break;
						}

						if (i + 1 < animals.Count && eatList[animals[i]].Contains($"|{animals[i + 1]}|"))
						{
							result.Add($"{animals[i]} eats {animals[i + 1]}");
							animals.RemoveAt(i + 1);
							break;
						}
					}

					if (i == animals.Count - 1)
					{
						canEat = false;
					}
				}
			}
			result.Add(string.Join(",", animals.Select((a) => a)));
			return result.ToArray();
		}
	}
	
}
//https://www.codewars.com/kata/5902bc7aba39542b4a00003d/train/csharp


//My test result in "visual studio" is passed but in codewars i have a problem with two test

//public static string[] WhoEatsWho(string zoo)
//{
//	Dictionary<string, List<string>> foodChain = new Dictionary<string, List<string>>
//			{
//				{ "antelope", new List<string> { "grass" } },
//				{ "big-fish", new List<string> { "little-fish" } },
//				{ "bug", new List<string> { "leaves" } },
//				{ "bear", new List<string> { "big-fish", "bug", "chicken", "cow", "leaves", "sheep" } },
//				{ "chicken", new List<string> { "bug" } },
//				{ "cow", new List<string> { "grass" } },
//				{ "fox", new List<string> { "chicken", "sheep" } },
//				{ "giraffe", new List<string> { "leaves" } },
//				{ "lion", new List<string> { "antelope", "cow" } },
//				{ "panda", new List<string> { "leaves" } },
//				{ "sheep", new List<string> { "grass" } }
//			};

//	var animals = zoo.Split(',').ToList();
//	var result = new List<string> { zoo };

//	bool anyAnimalEaten;

//	do
//	{
//		anyAnimalEaten = false;

//		for (int i = 0; i < animals.Count; i++)
//		{
//			if (i > 0 && foodChain.ContainsKey(animals[i]) && foodChain[animals[i]].Contains(animals[i - 1]))
//			{
//				result.Add($"{animals[i]} eats {animals[i - 1]}");
//				animals.RemoveAt(i - 1);
//				anyAnimalEaten = true;
//				break;
//			}
//			else if (i < animals.Count - 1 && foodChain.ContainsKey(animals[i]) && foodChain[animals[i]].Contains(animals[i + 1]))
//			{
//				result.Add($"{animals[i]} eats {animals[i + 1]}");
//				animals.RemoveAt(i + 1);
//				anyAnimalEaten = true;
//				break;
//			}
//		}

//	} while (anyAnimalEaten);

//	result.Add(string.Join(",", animals));
//	return result.ToArray();
//}