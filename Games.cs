using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Games
    {
        public string Team1 { get; set; }

        public int Team1Score { get; set; }
        public string Team2 { get; set; }

        public int Team2Score { get; set; }

        public Games() { }
        public Games (string Team1, int Team1Score, string Team2, int Team2Score)

        {
            this.Team1 = Team1;
            this.Team1Score = Team1Score;
            this.Team2 = Team2;
            this.Team2Score = Team2Score;
        }

        public override string ToString()
        {

            string score1 = "(" + Team1Score + ")  -";
            string score2 = "(" + Team2Score + ")";


            return String.Format("{0} {1} {2} {3}", Team1, score1, Team2, score2);
        }

      

    }

   
}
