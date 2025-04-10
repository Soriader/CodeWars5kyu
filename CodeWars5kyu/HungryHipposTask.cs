namespace CodeWars5kyu;

public class HungryHipposTask
{
    private int[,] board;
    private int rows;
    private int cols;

    public HungryHipposTask(int[,] board)
    {
        this.board = board;
        this.rows = board.GetLength(0);
        this.cols = board.GetLength(1);
    }

    public int Play()
    {
        int leaps = 0;
        bool[,] visited = new bool[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i, j] == 1 && !visited[i, j])
                {
                    leaps++;
                    BFS(i, j, visited);
                }
            }
        }

        return leaps;
    }

    private void BFS(int x, int y, bool[,] visited)
    {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((x, y));
        visited[x, y] = true;

        int[] dx = { -1, 1, 0, 0 }; 
        int[] dy = { 0, 0, -1, 1 };

        while (queue.Count > 0)
        {
            var (currentX, currentY) = queue.Dequeue();

            for (int k = 0; k < 4; k++)
            {
                int newX = currentX + dx[k];
                int newY = currentY + dy[k];

                if (newX >= 0 && newX < rows && newY >= 0 && newY < cols)
                {
                    if (board[newX, newY] == 1 && !visited[newX, newY])
                    {
                        visited[newX, newY] = true;
                        queue.Enqueue((newX, newY));
                    }
                }
            }
        }
    }
}
//https://www.codewars.com/kata/590300eb378a9282ba000095/train/csharp