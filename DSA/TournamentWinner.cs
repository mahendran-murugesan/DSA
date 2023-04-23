using System.Collections.Generic;
using System.Linq;

namespace DSA;

public class TournamentWinner
{
    public string Winner(List<List<string> > competitions, List<int> results)
    {
        Dictionary<string, int> teams = new Dictionary<string, int>();
        var winner = "";
        var loser = "";

        for (int i = 0; i < competitions.Count; i++)
        {
            if (results[i] != 0)
            {
                winner = competitions[i][0];
                loser = competitions[i][1];
            }
            else
            {
                winner = competitions[i][1];
                loser = competitions[i][0];
            }

            if (teams.ContainsKey(winner))
            {
                teams[winner] += 1;
            }
            else
            {
                teams.Add(winner, 1);
            }
            
            if (teams.ContainsKey(loser))
            {
                teams[loser] += 0;
            }
            else
            {
                teams.Add(loser, 0);
            }
        }

        var largeValue= teams.Values.Max();
        return teams.FirstOrDefault(x => x.Value == largeValue).Key;
    }
}