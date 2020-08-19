using fortnitewinner.helpers;
using fortnitewinner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortnitewinner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ResReader = new ResultsFileReader();
            
            
            string line = ResReader.ReadLine();
            line = ResReader.ReadLine();

            int BestScore = 0;
            string BestTeamName = "";
            while (line != null)
            {
                var parser = new ResultsLineParser(line);
                var model = parser.result;
                var score = model.KillsAchieved - model.KillsAgainst;
                if (score > BestScore)
                {
                    BestScore = score;
                    BestTeamName = model.TeamName;
                }
                line = ResReader.ReadLine();
            }
            



            Console.WriteLine( "Best Team Name : " + BestTeamName + " with score : " + BestScore);
            Console.ReadKey();
        }
    }
}
