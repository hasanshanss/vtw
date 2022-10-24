using System.Reflection;
using System.Runtime.CompilerServices;
using VTW.ConsoleClientSample;


Random random = new Random();


Team team1 = new("Real", 1, 100);
Team team2 = new("Barca", 100, 1);
List<Team> teams = new List<Team> { team1, team2 };

//find the difference of totals
teams = teams.OrderByDescending(t => t.Total).ToList();
double diff = ((teams[1].Total * 100) / teams[0].Total);
bool isPayable = diff >= 51;
double coeff = isPayable ? (diff/100) + 1 : 2 - (diff / 100);
double win;

if (isPayable)
{
    //find the most average
    teams= teams.OrderByDescending(t => t.Average).ToList();

    //if the averages are the same, then the preference is given to the team with the less people
    if (team1.Average == team2.Average)
    {
        teams = teams.OrderBy(t => t.People).ToList();
    }

    win = teams[0].Total * coeff;


}
else
{
    win = teams[1].Total * coeff;
}


Console.ReadLine();



