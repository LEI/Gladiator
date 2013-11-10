using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Match
	{
		private string _resultMatch;
		public string ResultMatch
		{
			get { return this._resultMatch; }
			set { this._resultMatch = value; }
		}

        private Team _lstStillALive;
        public Team StillAlive
        {
            get { return this._lstStillALive; }
            set { this._lstStillALive = value; }
        }

		// MATCH
		public Match(Team t1, Team t2)
		{
			Round currentRound;

			int i = 0, j = 0, nbRound = 1;
			while (t1.ChampList[2].IsAlive && t2.ChampList[2].IsAlive && i <= 3 && j <= 3) {
				ResultMatch += "\n----- ROUND " + nbRound + " - " + t1.ChampList[i].Name + " vs " + t2.ChampList[j].Name + " -----\n";
                if (t1.ChampList[i].IsAlive && t2.ChampList[j].IsAlive)
                {
					currentRound = new Round(t1.ChampList[i], t2.ChampList[j]);
					ResultMatch += currentRound.Result;
                    nbRound++;
                }
				
                if (!t1.ChampList[i].IsAlive)
                    i++;
                if (!t2.ChampList[j].IsAlive)
                    j++;
				//Console.WriteLine(t1.ChampList[i].Name + " : " + t1.ChampList[i].IsAlive.ToString());
				//Console.WriteLine(t2.ChampList[j].Name + " : " + t2.ChampList[j].IsAlive.ToString());
			}
			if (i > j) {
				ResultMatch += t2.Name + " gagne le match contre " + t1.Name;
                StillAlive = t2;
				t2.NbWin++;
				t1.NbLose++;
			} else if (i < j) {
				ResultMatch += t1.Name + " gagne le match contre " + t2.Name;
                StillAlive = t1;
				t1.NbWin++;
				t2.NbLose++;
			} else if (i == j) {
				ResultMatch += "Egalité entre " + t1.Name + " et " + t2.Name;
				t1.NbDraw++;
				t2.NbDraw++;
			}

			// On rez les champions après chaque combat d'équipe
			// -> ils recombatent dans les prochains matchs et on ne peut pas tester la dernière équipe vivante comme avant
            foreach (Champion c in t1.ChampList)
            {
                c.IsAlive = true;
            }
            foreach (Champion c in t2.ChampList)
            {
                c.IsAlive = true;
            }

		}
	}
}

