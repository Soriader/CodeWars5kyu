namespace CodeWars5kyu;

public class SunkDamagedOrNotTouchedTask
{
    public static Dictionary<string,double> DamagedOrSunk(int[,] board, int[,] attacks)
    {
        double sunk = 0;
        double damaged = 0;
        double notTouched = 0;
        double points = 0;

        Dictionary<int, int> shipLengths = new Dictionary<int, int>();
        Dictionary<int, int> hits = new Dictionary<int, int>();

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                int ship = board[i, j];
                if (ship != 0)
                {
                    if (!shipLengths.ContainsKey(ship))
                    {
                        shipLengths[ship] = 0;
                        hits[ship] = 0;
                    }
                    shipLengths[ship]++;
                }
            }
        }

        for (int i = 0; i < attacks.GetLength(0); i++)
        {
            int x = attacks[i, 0] - 1; 
            int y = board.GetLength(0) - attacks[i, 1];

            if (x >= 0 && x < board.GetLength(1) && y >= 0 && y < board.GetLength(0))
            {
                int ship = board[y, x];
                if (ship != 0)
                {
                    hits[ship]++;
                }
            }
        }

        foreach (var ship in shipLengths.Keys)
        {
            int length = shipLengths[ship];
            int hitCount = hits[ship];

            if (hitCount == 0)
            {
                notTouched++;
                points -= 1;
            }
            else if (hitCount == length)
            {
                sunk++;
                points += 1;
            }
            else
            {
                damaged++;
                points += 0.5;
            }
        }

        return new Dictionary<string, double>()
        {
            {"sunk", sunk},
            {"damaged", damaged},
            {"notTouched", notTouched},
            {"points", points}
        };
    }
}
//https://www.codewars.com/kata/58d06bfbc43d20767e000074/train/csharp