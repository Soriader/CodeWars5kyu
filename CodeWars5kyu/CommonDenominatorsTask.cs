using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class CommonDenominatorsTask
    {
        public static string ConvertFrac(long[,] lst)
        {

            if (lst.GetLength(0) == 0)
            {
                return string.Empty; 
            }

            List<long> denominators = new List<long>();

            for (int i = 0; i < lst.GetLength(0); i++)
            {
                if (lst[i, 1] == 0) 
                {
                    throw new ArgumentException("The denominator cannot be zero.");
                }

                denominators.Add(lst[i, 1]);
            }

            long commonDenominator = Lcm(denominators);

            List<string> resultFractions = new List<string>();

            for (int i = 0; i < lst.GetLength(0); i++)
            {
                long numerator = lst[i, 0];
                long denominator = lst[i, 1];
                long newNumerator = numerator * (commonDenominator / denominator);
                resultFractions.Add($"({newNumerator},{commonDenominator})");
            }

            return string.Join("", resultFractions);
        }

        public static long Lcm(List<long> numbers)
        {
            return numbers.Aggregate(Lcm);
        }

        public static long Lcm(long a, long b)
        {
            return a * (b / Gcd(a, b));
        }

        public static long Gcd(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
//https://www.codewars.com/kata/54d7660d2daf68c619000d95/train/csharp