using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class FirstVariationOnCaesarCipherTask
	{
		public static List<string> MovingShift(string s, int shift)
		{
			StringBuilder encoded = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				encoded.Append(ShiftChar(s[i], shift + i));
			}

			List<string> parts = new List<string>(5);
			int totalLength = encoded.Length;
			int partLength = (int)Math.Ceiling(totalLength / 5.0);

			int currentIndex = 0;
			for (int i = 0; i < 5; i++)
			{
				int currentPartLength = Math.Min(partLength, totalLength - currentIndex);
				if (currentPartLength > 0)
				{
					parts.Add(encoded.ToString(currentIndex, currentPartLength));
					currentIndex += currentPartLength;
				}
				else
				{
					parts.Add("");
				}
			}

			return parts;
		}

		public static string DemovingShift(List<string> s, int shift)
		{
			StringBuilder combined = new StringBuilder();
			foreach (var part in s)
			{
				combined.Append(part);
			}

			StringBuilder decoded = new StringBuilder();
			for (int i = 0; i < combined.Length; i++)
			{
				decoded.Append(ShiftChar(combined[i], -(shift + i)));
			}

			return decoded.ToString();
		}

		private static char ShiftChar(char c, int shift)
		{
			if (char.IsLetter(c))
			{
				char baseChar = char.IsUpper(c) ? 'A' : 'a';
				int alphabetSize = 26;
				int newPos = (c - baseChar + shift) % alphabetSize;
				if (newPos < 0) newPos += alphabetSize;
				return (char)(baseChar + newPos);
			}
			return c;
		}

	} 
}

//https://www.codewars.com/kata/5508249a98b3234f420000fb/train/csharp