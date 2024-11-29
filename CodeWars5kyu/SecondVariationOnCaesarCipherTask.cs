using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class SecondVariationOnCaesarCipherTask
	{
		public static Dictionary<char, int> AlphabetIndex = new Dictionary<char, int>
		{
			{'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5},
			{'f', 6}, {'g', 7}, {'h', 8}, {'i', 9}, {'j', 10},
			{'k', 11}, {'l', 12}, {'m', 13}, {'n', 14}, {'o', 15},
			{'p', 16}, {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20},
			{'u', 21}, {'v', 22}, {'w', 23}, {'x', 24}, {'y', 25},
			{'z', 26}
		};

		public static List<string> encodeStr(string s, int shift)
		{
			char firstChar = char.ToLower(s[0]);
			char secondChar = (char)(((firstChar - 'a' + shift) % 26) + 'a');

			string prefix = $"{firstChar}{secondChar}";

			string encryptedMessage = "";
			foreach (char ch in s)
			{
				if (char.IsLower(ch))
				{
					encryptedMessage += (char)(((ch - 'a' + shift) % 26) + 'a');
				}
				else if (char.IsUpper(ch))
				{
					encryptedMessage += (char)(((ch - 'A' + shift) % 26) + 'A');
				}
				else
				{
					encryptedMessage += ch;
				}
			}

			string fullMessage = prefix + encryptedMessage;

			List<string> parts = new List<string>();
			int partLength = (int)Math.Ceiling((double)fullMessage.Length / 5);

			for (int i = 0; i < 5; i++)
			{
				int startIndex = i * partLength;
				if (startIndex < fullMessage.Length)
				{
					int length = Math.Min(partLength, fullMessage.Length - startIndex);
					parts.Add(fullMessage.Substring(startIndex, length));
				}
			}

			return parts;
		}

		public static string decode(List<string> s)
		{
			var str = string.Concat(s);

			var shift = str[1] - str[0];
			str = str.Remove(0, 2);

			var sb = new StringBuilder();

			for (int i = 0; i < str.Length; i++)
			{
				var ch = str[i];

				if (char.IsLetter(ch))
				{
					if (char.IsLower(ch))
					{
						ch = (char)(((ch - 'a' - shift + 26) % 26) + 'a');
					}
					else if (char.IsUpper(ch))
					{
						ch = (char)(((ch - 'A' - shift + 26) % 26) + 'A');
					}
				}

				sb.Append(ch);
			}

			return sb.ToString();
		}
	}
}
//https://www.codewars.com/kata/55084d3898b323f0aa000546/train/csharp