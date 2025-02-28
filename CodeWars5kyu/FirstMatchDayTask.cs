namespace CodeWars5kyu;
public class FirstMatchDayTask
{
    public static string Table(string[] results)
    {
        var standings = new Dictionary<string, TeamStats>();

        foreach (var match in results)
        {
            string[] parts = match.Split(new[] { " - " }, StringSplitOptions.None);
            string[] firstPart = parts[0].Split(new[] { ' ' }, 2);
            string score = firstPart[0];
            string team1 = firstPart[1];
            string team2 = parts[1];

            if (!standings.ContainsKey(team1))
                standings[team1] = new TeamStats(team1);
            if (!standings.ContainsKey(team2))
                standings[team2] = new TeamStats(team2);

            if (score == "-:-") continue;

            string[] goals = score.Split(':');
            int goalsTeam1 = int.Parse(goals[0]);
            int goalsTeam2 = int.Parse(goals[1]);

            standings[team1].GamesPlayed++;
            standings[team2].GamesPlayed++;
            standings[team1].GoalsFor += goalsTeam1;
            standings[team1].GoalsAgainst += goalsTeam2;
            standings[team2].GoalsFor += goalsTeam2;
            standings[team2].GoalsAgainst += goalsTeam1;

            if (goalsTeam1 > goalsTeam2)
            {
                standings[team1].Wins++;
                standings[team1].Points += 3;
                standings[team2].Losses++;
            }
            else if (goalsTeam1 < goalsTeam2)
            {
                standings[team2].Wins++;
                standings[team2].Points += 3;
                standings[team1].Losses++;
            }
            else
            {
                standings[team1].Draws++;
                standings[team2].Draws++;
                standings[team1].Points++;
                standings[team2].Points++;
            }
        }

        var sortedTeams = standings.Values
            .OrderByDescending(t => t.Points)
            .ThenByDescending(t => t.GoalDifference)
            .ThenByDescending(t => t.GoalsFor)
            .ThenBy(t => t.Name, StringComparer.OrdinalIgnoreCase)
            .ToList();

        string result = "";
        int rank = 1;
        for (int i = 0; i < sortedTeams.Count; i++)
        {
            if (i > 0 &&
                (sortedTeams[i].Points < sortedTeams[i - 1].Points ||
                 sortedTeams[i].GoalDifference < sortedTeams[i - 1].GoalDifference ||
                 sortedTeams[i].GoalsFor < sortedTeams[i - 1].GoalsFor))
            {
                rank = i + 1;
            }

            result += $"{rank,2}. {sortedTeams[i].FormattedOutput()}\n";
        }

        return result.TrimEnd();
    }
}

public class TeamStats
{
    public string Name { get; }
    public int GamesPlayed { get; set; } = 0;
    public int Wins { get; set; } = 0;
    public int Draws { get; set; } = 0;
    public int Losses { get; set; } = 0;
    public int GoalsFor { get; set; } = 0;
    public int GoalsAgainst { get; set; } = 0;
    public int Points { get; set; } = 0;
    public int GoalDifference => GoalsFor - GoalsAgainst;

    public TeamStats(string name)
    {
        Name = name;
    }

    public string FormattedOutput()
    {
        return $"{Name,-29} {GamesPlayed}  {Wins}  {Draws}  {Losses}  {GoalsFor}:{GoalsAgainst}  {Points}";
    }
}
//https://www.codewars.com/kata/57c178e16662d0d932000120/train/csharp