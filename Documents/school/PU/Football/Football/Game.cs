using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<string> AssistantReferees { get; set; }
        public List<Tuple<int, FootballPlayer>> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }

    }
}
