using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class MatchingAndSubstitutingTask
	{
		public static string Change(string s, string prog, string version)
		{
			string[] lines = s.Split('\n');
			string result = "";

			bool versionValid = true;
			bool phoneValid = true;

			foreach (var line in lines)
			{
				if (line.StartsWith("Program title"))
				{
					result += $"Program: {prog} ";
				}
				else if (line.StartsWith("Author"))
				{
					result += "Author: g964 ";
				}
				else if (line.StartsWith("Phone"))
				{
					if (!System.Text.RegularExpressions.Regex.IsMatch(line, @"\+1-\d{3}-\d{3}-\d{4}"))
					{
						phoneValid = false;
						break;
					}
					result += "Phone: +1-503-555-0090 ";
				}
				else if (line.StartsWith("Date"))
				{
					result += "Date: 2019-01-01 ";
				}
				else if (line.StartsWith("Version"))
				{
					var versionPart = line.Split(':')[1].Trim();
					if (versionPart != "2.0" && System.Text.RegularExpressions.Regex.IsMatch(versionPart, @"^\d+\.\d+$"))
					{
						result += $"Version: {version} ";
					}
					else if (versionPart == "2.0")
					{
						result += $"Version: 2.0 ";
					}
					else
					{
						versionValid = false;
						break;
					}
				}
			}

			return versionValid && phoneValid ? result.Trim() : "ERROR: VERSION or PHONE";
		}
	}
}
//https://www.codewars.com/kata/59de1e2fe50813a046000124/train/csharp