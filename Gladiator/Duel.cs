using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Duel
	{

		private Champion _champion1;
		public Champion Champion1
		{
			get { return this._champion1; }
			set { this._champion1 = value; }
		}

		private Champion _champion2;
		public Champion Champion2
		{
			get { return this._champion2; }
			set { this._champion2 = value; }
		}

        private Team _lstStillALive;
        public Team StillAlive
        {
            get { return this._lstStillALive; }
            set { this._lstStillALive = value; }
        }

		public Duel(Team t1, Team t2)
		{
			int i = 0, j = 0, nbRound = 1;
			while (t1.ChampList[2].IsAlive & t2.ChampList[2].IsAlive & i < 3 & j < 3) {
				if (!t1.ChampList[i].IsAlive)
					i++;
				if (!t2.ChampList[j].IsAlive)
					j++;
				Console.WriteLine("\n----- ROUND " + nbRound + " - " + t1.ChampList[i].Name + " vs " + t2.ChampList[j].Name + " -----\n");
				new Round(t1.ChampList[i], t2.ChampList[j]);
				nbRound++;
				//Console.WriteLine(t1.ChampList[i].Name + " : " + t1.ChampList[i].IsAlive.ToString());
				//Console.WriteLine(t2.ChampList[j].Name + " : " + t2.ChampList[j].IsAlive.ToString());
			}
			if (i > j) {
				Console.WriteLine(t2.Name + " gagne le duel contre "+ t1.Name);
                StillAlive = t2;
				t2.NbWin++;
				t1.NbLose++;
			} else if (i < j) {
				Console.WriteLine(t1.Name + " perd le duel contre " + t2.Name);
                StillAlive = t1;
				t1.NbWin++;
				t2.NbLose++;
			} else if (i == j) {
                Console.WriteLine("Egalité entre " + t1.Name + " et " + t2.Name);
				t1.NbDraw++;
				t2.NbDraw++;
			}

		}
	}
}

