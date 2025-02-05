namespace CodeWars5kyu;

public class SortOneThreeTwoTask
{
    public static int[] Sort(int[] array)
    {
        var result = new List<int>();
        var listForSortetStrings = new List<string>();
        var parsOfNumbrs = new Dictionary<int, string>();

        foreach (var num in array)
        {
            listForSortetStrings.Add(NumberToWords(num));

            if (parsOfNumbrs.ContainsKey(num))
            {
                continue;
            }
            else
            {
                parsOfNumbrs.Add(num, NumberToWords(num));
            }
        } 
        
        listForSortetStrings = listForSortetStrings.OrderBy(x => x).ToList();

        foreach (string item in listForSortetStrings)
        {
            var number = parsOfNumbrs.FirstOrDefault(x => x.Value == item).Key;
            result.Add(number);
        }
        
        
        return result.ToArray();
    }
    
    private static string NumberToWords(int number)
    {
        if (number < 0 || number > 999)
        {
            return "Number out of range";
        }

        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", 
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", 
            "seventeen", "eighteen", "nineteen" };

        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number < 20)
        {
            return ones[number];  
        }
        else if (number < 100)
        {
            return tens[number / 10] + (number % 10 > 0 ? "-" + ones[number % 10] : "");  
        }
        else
        {
            int hundreds = number / 100;
            int remainder = number % 100;

            string result = ones[hundreds] + " hundred";  

            if (remainder > 0)
            {
                result += " and " + NumberToWords(remainder); 
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/56f4ff45af5b1f8cd100067d/train/csharp