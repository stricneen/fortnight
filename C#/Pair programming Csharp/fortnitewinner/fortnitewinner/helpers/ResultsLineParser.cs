using fortnitewinner.Model;
using System;
using System.Security.Cryptography.X509Certificates;

namespace fortnitewinner.helpers
{
    public class ResultsLineParser
    {
        public FortniteResult result = null;

        public ResultsLineParser(String resultsLine )
        {
            string[] lineData = resultsLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            result = new FortniteResult()
            {
                TeamName = lineData[0],
                NumberInTeam = int.Parse(lineData[1]),
                KillsAchieved = int.Parse(lineData[2]),
                KillsAgainst = int.Parse(lineData[3])
            };
        }

        public string GetTeamName()
        {
            return result.TeamName;     
        }

        public FortniteResult GetResultModel()
        {
            return result;
        }
    }
}
