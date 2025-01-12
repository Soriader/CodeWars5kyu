using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class BasicNicoVariationTask
    {
        public static string Nico(string key, string message)
        {

            var result = "";

            while (message.Length % key.Length != 0)
            {
                message += " ";
            }

            for (int i = 0; i < message.Length; i += key.Length)
            {
                var segment = message.Skip(i).Take(key.Length).ToArray();
                var sortedKey = key.ToArray();
                Array.Sort(sortedKey, segment);

                result = segment.Aggregate(result, (current, c) => current + c);
            }

            return result;
        }

    }
}
//https://www.codewars.com/kata/5968bb83c307f0bb86000015/train/csharp