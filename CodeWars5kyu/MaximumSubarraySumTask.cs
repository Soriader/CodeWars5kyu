using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class MaximumSubarraySumTask
    {
        public static int MaxSequence(int[] arr)
        {

            if (arr.Length == 0)
                return 0;

            int maxEndingHere = arr[0];
            int maxSoFar = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return Math.Max(maxSoFar, 0);
        }
    }
}
