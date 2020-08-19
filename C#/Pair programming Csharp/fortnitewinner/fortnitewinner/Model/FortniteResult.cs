using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace fortnitewinner.Model
{
    public class FortniteResult
    {
        public string TeamName { get; set; }
        public int NumberInTeam { get; set; }
        public int KillsAchieved { get; set; }
        public int KillsAgainst { get; set; }

    }
}
