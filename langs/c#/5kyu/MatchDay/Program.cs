using System.Text;

Table(new []
{
    "6:0 FC Bayern Muenchen - Werder Bremen",
    "-:- Eintracht Frankfurt - Schalke 04",
    "-:- FC Augsburg - VfL Wolfsburg",
    "-:- Hamburger SV - FC Ingolstadt",
    "-:- 1. FC Koeln - SV Darmstadt",
    "-:- Borussia Dortmund - FSV Mainz 05",
    "-:- Borussia Moenchengladbach - Bayer Leverkusen",
    "-:- Hertha BSC Berlin - SC Freiburg",
    "-:- TSG 1899 Hoffenheim - RasenBall Leipzig"
});

Table(new []
{
    "1:2 FC Bayern Muenchen - Werder Bremen",
    "2:2 Eintracht Frankfurt - Schalke 04",
    "3:4 FC Augsburg - VfL Wolfsburg",
    "3:0 Hamburger SV - FC Ingolstadt",
    "0:4 1. FC Koeln - SV Darmstadt",
    "4:0 Borussia Dortmund - FSV Mainz 05",
    "5:3 Borussia Moenchengladbach - Bayer Leverkusen",
    "2:1 Hertha BSC Berlin - SC Freiburg",
    "2:2 TSG 1899 Hoffenheim - RasenBall Leipzig"
});
/*
Expected:
 1. Borussia Dortmund             1  1  0  0  4:0  3
 1. SV Darmstadt                  1  1  0  0  4:0  3
 3. Hamburger SV                  1  1  0  0  3:0  3
 4. Borussia Moenchengladbach     1  1  0  0  5:3  3
 5. VfL Wolfsburg                 1  1  0  0  4:3  3
 6. Hertha BSC Berlin             1  1  0  0  2:1  3
 6. Werder Bremen                 1  1  0  0  2:1  3
 8. Eintracht Frankfurt           1  0  1  0  2:2  1
 8. RasenBall Leipzig             1  0  1  0  2:2  1
 8. Schalke 04                    1  0  1  0  2:2  1
 8. TSG 1899 Hoffenheim           1  0  1  0  2:2  1
12. FC Augsburg                   1  0  0  1  3:4  0
13. FC Bayern Muenchen            1  0  0  1  1:2  0
13. SC Freiburg                   1  0  0  1  1:2  0
15. Bayer Leverkusen              1  0  0  1  3:5  0
16. FC Ingolstadt                 1  0  0  1  0:3  0
17. 1. FC Koeln                   1  0  0  1  0:4  0
17. FSV Mainz 05                  1  0  0  1  0:4  0
*/

static string Table(string[] results)
{
    var d = new Dictionary<string, Team>();

    foreach(var game in results)
    {
        var gameInfo = ExtractInfoAboutAnGame(game);

        if(!d.ContainsKey(gameInfo.NameTeamLeft))
        {
            d.Add(gameInfo.NameTeamLeft, new Team());
            d[gameInfo.NameTeamLeft].Name = gameInfo.NameTeamLeft;
        }

        if(!d.ContainsKey(gameInfo.NameTeamRight))
        {
            d.Add(gameInfo.NameTeamRight, new Team());
            d[gameInfo.NameTeamRight].Name = gameInfo.NameTeamRight;
        }

        if(gameInfo.GoalTeamLeft > -1)
        {
            if(gameInfo.GoalTeamLeft < gameInfo.GoalTeamRight)
            {
                d[gameInfo.NameTeamRight].WonMatches += 1;
                d[gameInfo.NameTeamLeft].LostMatches += 1;
            }
            else if(gameInfo.GoalTeamLeft > gameInfo.GoalTeamRight)
            {
                d[gameInfo.NameTeamRight].LostMatches += 1;
                d[gameInfo.NameTeamLeft].WonMatches += 1;
            }
            else
            {
                d[gameInfo.NameTeamRight].TieMatches += 1;
                d[gameInfo.NameTeamLeft].TieMatches += 1;
            }

            d[gameInfo.NameTeamRight].PlayedMatches += 1;
            d[gameInfo.NameTeamLeft].PlayedMatches += 1;

            d[gameInfo.NameTeamRight].GoalsShot += gameInfo.GoalTeamRight;
            d[gameInfo.NameTeamLeft].GoalsShot += gameInfo.GoalTeamLeft;

            d[gameInfo.NameTeamRight].goalsGotten += gameInfo.GoalTeamLeft;
            d[gameInfo.NameTeamLeft].goalsGotten += gameInfo.GoalTeamRight;
        }
    }

    var teams = d.Values.ToList();
    teams.Sort();

    var r = new StringBuilder();

    int pos = 1;
    r.Append($"{(pos).ToString().PadLeft(2, ' ')}. {FormatTeamInfo(teams[0])}\n");

    for(int i = 1; i < teams.Count - 1; i++)
    {
        if(!teams[i - 1].TeamAtSamePosition(teams[i]))
        {
            pos = i + 1;
        }
        r.Append($"{(pos).ToString().PadLeft(2, ' ')}. {FormatTeamInfo(teams[i])}\n");
    }
    if(teams[^1].TeamAtSamePosition(teams[^2]))
        r.Append($"{(pos).ToString().PadLeft(2, ' ')}. {FormatTeamInfo(teams[^1])}");
    else
        r.Append($"{(teams.Count).ToString().PadLeft(2, ' ')}. {FormatTeamInfo(teams[^1])}");
    
    Console.WriteLine(r.ToString());
    return r.ToString();
}

static string FormatTeamInfo(Team team)
{
    var sb = new StringBuilder();
    sb.Append(team.Name.PadRight(30, ' '));
    sb.Append($"{team.PlayedMatches}  ");
    sb.Append($"{team.WonMatches}  ");
    sb.Append($"{team.TieMatches}  ");
    sb.Append($"{team.LostMatches}  ");
    sb.Append($"{team.GoalsShot}:{team.goalsGotten}  ");
    sb.Append($"{team.Points}");
    return sb.ToString();
}

static (int GoalTeamLeft, int GoalTeamRight, string NameTeamLeft, string NameTeamRight) ExtractInfoAboutAnGame(string game)
{
    var indexOfFirstSpace = game.IndexOf(' ');
    var goals = game.Substring(0, indexOfFirstSpace).Split(':');
    var teams = game.Substring(indexOfFirstSpace).Split(" - ");
    
    return (goals[0].StartsWith('-') || goals[1].StartsWith('-'))
        ? (-1, -1, teams[0].Trim(), teams[1].Trim())
        : (Convert.ToInt32(goals[0]), Convert.ToInt32(goals[1]), teams[0].Trim(), teams[1].Trim());
}

public class Team : IComparable<Team>
{
    public string Name { get; set; }
	public int PlayedMatches { get; set; }
	public int WonMatches { get; set; }
	public int TieMatches { get; set; }
	public int LostMatches { get; set; }
	public int GoalsShot { get; set; }
	public int goalsGotten { get; set; }
	public int Points
	{
		get => WonMatches * 3 + TieMatches * 1;
	}

    public int CompareTo(Team other)
    {
        // seq of compare: Points > Goal Pro - Goal Got > Goal Pro > Name
        int r = 0;

        if(this.Points > other.Points) 
            r = -1;
        else if(this.Points < other.Points) 
            r = 1;
        else // Points equal
        {
            if((this.GoalsShot - this.goalsGotten) > (other.GoalsShot - other.goalsGotten))
                r = -1;
            else if((this.GoalsShot - this.goalsGotten) < (other.GoalsShot - other.goalsGotten))
                r = 1;
            else // Diff of goals equal
            {
                if(this.GoalsShot > other.GoalsShot)
                    r = -1;
                else if(this.GoalsShot < other.GoalsShot)
                    r = 1;
                else // Goals shot equal, then compare the name
                    r = this.Name.CompareTo(other.Name);
            }
        }

        return r;
    }

    public bool TeamAtSamePosition(Team other)
    {
        return 
            this.Points == other.Points 
            && (this.GoalsShot - this.goalsGotten) == (other.GoalsShot - other.goalsGotten)
            && this.GoalsShot == other.GoalsShot;
    }
}