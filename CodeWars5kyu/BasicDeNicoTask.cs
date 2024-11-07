using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class BasicDeNicoTask
	{
		public static string DeNico(string key, string message)
		{
			string result = "";
			var alphabetToNewKey = key.OrderBy(x => x).ToList();
			List<int> newKey = new List<int>();


			for (int i = 0; i < key.Length; i++)
			{
				int position = alphabetToNewKey.IndexOf(key[i]) + 1;
				newKey.Add(position);
			}

			List<string> groups = new List<string>();

			for (int i = 0; i < message.Length; i += newKey.Count)
			{
				string group = message.Substring(i, Math.Min(newKey.Count, message.Length - i));
				groups.Add(group);
			}

			int iterator = 0;

			foreach (var letter in groups)
			{
				var check = letter.ToCharArray();

				while (iterator < newKey.Count)
				{
					if (newKey[iterator] - 1 < letter.Length)
					{
						result += letter[newKey[iterator] - 1]; 
					}
					iterator++;
				}

				iterator = 0;
			}

			return result.TrimEnd();
		}
	}
}
//https://www.codewars.com/kata/596f610441372ee0de00006e/train/csharp