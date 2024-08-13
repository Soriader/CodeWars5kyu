using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class PhoneDirectoryTask
	{
		public static string Phone(string strng, string num)
		{
			string[] lines = strng.Split('\n');
			string foundName = null;
			string foundAddress = null;
			int count = 0;

			foreach (string line in lines)
			{
				if (Regex.IsMatch(line, $@"\b\+?{Regex.Escape(num)}\b"))
				{
					count++;
					if (count > 1)
					{
						return $"Error => Too many people: {num}";
					}

					var nameMatch = Regex.Match(line, @"<(.+?)>");
					if (nameMatch.Success)
					{
						foundName = nameMatch.Groups[1].Value;
					}

					string cleanedLine = Regex.Replace(line, @"<(.+?)>", "");
					cleanedLine = Regex.Replace(cleanedLine, Regex.Escape(num), "");
					cleanedLine = Regex.Replace(cleanedLine, @"[^a-zA-Z0-9\.\-\s]", " ");
					foundAddress = Regex.Replace(cleanedLine.Trim(), @"\s+", " ");
				}
			}

			if (count == 0)
			{
				return $"Error => Not found: {num}";
			}

			return $"Phone => {num}, Name => {foundName}, Address => {foundAddress}";
		}
	}
}
//https://www.codewars.com/kata/56baeae7022c16dd7400086e/train/csharp