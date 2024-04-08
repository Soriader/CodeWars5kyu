using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class Rot13Task
    {
        public static string Rot13(string message)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';

                    char rotatedChar = (char)((c - offset + 13) % 26 + offset);

                    result.Append(rotatedChar);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
