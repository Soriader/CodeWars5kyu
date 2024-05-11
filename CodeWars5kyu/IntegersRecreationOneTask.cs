using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class IntegersRecreationOneTask
    {
        public static string ListSquared(long m, long n)
        {
            List<List<long>> result = new List<List<long>>();

            for (long i = m; i <= n; i++)
            {
                long sumOfSquaredDivisors = SumOfSquaredDivisors(i);
                long squareRoot = (long)Math.Sqrt(sumOfSquaredDivisors);

                if (squareRoot * squareRoot == sumOfSquaredDivisors)
                {
                    List<long> pair = new List<long>() { i, sumOfSquaredDivisors };
                    result.Add(pair);
                }
            }

            return "[" + string.Join(", ", result.Select(pair => "[" + string.Join(", ", pair) + "]")) + "]";
        }

        private static long SumOfSquaredDivisors(long number)
        {
            long sum = 0;
            for (long i = 1; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    sum += i * i;
                    if (i != number / i)
                    {
                        sum += (number / i) * (number / i);
                    }
                }
            }
            return sum;
        }
    }
}
//https://www.codewars.com/kata/55aa075506463dac6600010d/train/csharp