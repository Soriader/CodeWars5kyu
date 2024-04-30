using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars5kyu
{
    public class PrimesInNumbersTask
    {
        public static String Factors(int lst)
        {
            string result = "";
            int count = 0;
            for (int i = 2; i <= lst; i++)
            {
                count = 0;
                while (lst % i == 0)
                {
                    count++;
                    lst /= i;
                }
                if (count > 0)
                {
                    result += "(" + i;
                    if (count > 1)
                    {
                        result += "**" + count;
                    }
                    result += ")";
                }
            }

            return result;
        }
    }
}
//https://chat.openai.com/c/28395c0e-7528-4740-a026-ec220c04082e