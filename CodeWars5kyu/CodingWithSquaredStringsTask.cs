namespace CodeWars5kyu;

public class CodingWithSquaredStringsTask
{
    public static string Code(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        
        int l = s.Length;
        int n = (int)Math.Ceiling(Math.Sqrt(l));
        char paddingChar = (char)11;

        s = s.PadRight(n * n, paddingChar);
        
        char[,] grid = new char[n, n];
        for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            grid[i, j] = s[i * n + j];

        char[,] rotated = new char[n, n];
        for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            rotated[j, n - 1 - i] = grid[i, j];

        return string.Join("\n", Enumerable.Range(0, n)
            .Select(row => new string(Enumerable.Range(0, n)
                .Select(col => rotated[row, col]).ToArray())));
    }

    public static string Decode(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        
        string[] lines = s.Split('\n');
        int n = lines.Length;
        char[,] grid = new char[n, n];

        for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            grid[i, j] = lines[i][j];

        char[,] rotated = new char[n, n];
        for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            rotated[n - 1 - j, i] = grid[i, j];

        string result = string.Join("", Enumerable.Range(0, n)
            .SelectMany(row => Enumerable.Range(0, n)
                .Select(col => rotated[row, col])));

        return result.TrimEnd((char)11);
    }
}
//https://www.codewars.com/kata/56fcc393c5957c666900024d/train/csharp