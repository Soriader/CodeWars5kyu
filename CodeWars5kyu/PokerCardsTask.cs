using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
	public class PokerCardsTask
	{
		private static readonly string[] Values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K" };
		private static readonly char[] Suits = { 'c', 'd', 'h', 's' };

		public static int[] Encode(string[] cards)
		{
			return cards.Select(card =>
				{
					var value = card[0].ToString();
					var suit = card[1];

					int valueIndex = Array.IndexOf(Values, value);
					int suitOffset = Array.IndexOf(Suits, suit);

					return suitOffset * 13 + valueIndex;
				})
				.OrderBy(code => code) .ToArray();
		}

		public static string[] Decode(int[] cards)
		{
			return cards.OrderBy(code => code).Select(code =>
				{
					int valueIndex = code % 13;
					int suitIndex = code / 13;

					return Values[valueIndex] + Suits[suitIndex];
				}).ToArray();
		}
	}

}
//https://www.codewars.com/kata/52ebe4608567ade7d700044a/train/csharp