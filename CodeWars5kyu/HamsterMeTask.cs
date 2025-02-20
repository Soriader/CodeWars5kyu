namespace CodeWars5kyu;

public class HamsterMeTask
{
    public static string HamsterMe(string code, string message) 
    {
        var key = new Dictionary<char, string>();
        code = string.Concat(code.Distinct().OrderBy(c => c));
        
        for (int i = 0; i < code.Length; i++)
        {
            var letter = code[i];
            var nextLetter = i + 1 < code.Length ? code[i + 1] : (char)(code[0] + 26);
            
            for (int j = letter, k = 1; j < nextLetter; j++, k++)
            {
                if (j <= 'z')
                {
                    key[(char)j] = $"{letter}{k}";
                }
                else
                {
                    key[(char)(j - 26)] = $"{letter}{k}";
                }
            }
        }
        return string.Join("", message.Select(c => $"{key[c]}"));
    }
    
    
}
//https://www.codewars.com/kata/595ddfe2fc339d8a7d000089/train/csharp