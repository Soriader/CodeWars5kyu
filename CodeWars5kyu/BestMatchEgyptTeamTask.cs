using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class BestMatchEgyptTeamTask
    {
        public int BestMatch(int[] goals1, int[] goals2)
        {
            int bestMatchIndex = -1;
            int smallestDifference = int.MaxValue;
            int mostGoals = -1;

            for (int i = 0; i < goals1.Length; i++)
            {
                int difference = goals1[i] - goals2[i];

                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    mostGoals = goals2[i]; 
                    bestMatchIndex = i;
                }
                else if (difference == smallestDifference && goals2[i] > mostGoals)
                {
                    mostGoals = goals2[i];
                    bestMatchIndex = i;
                }
            }

            return bestMatchIndex;
        }
    }
}
//https://www.codewars.com/kata/58b38256e51f1c2af0000081/train/csharp