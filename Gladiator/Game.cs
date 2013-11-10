using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Game
	{
		private string _result;
		public string Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		private List<Team> _teamsRegistered;
		public List<Team> TeamsRegistered
		{
			get { return this._teamsRegistered; }
			set { this._teamsRegistered = value; }
		}

		public Game(params Player[] t_players)
		{
			TeamsRegistered = new List<Team>();
			// Vérification du nombre minimum de joueur
			if (t_players.Length > 1) {
				foreach (Player p in t_players) {
					// Vérification du nombre d'équipes
					if (p.TeamList.Count > 0) {
						TeamsRegistered.Add(p.TeamList[0]);
					} else {
						this.Result = "Le joueur " + p.Alias + " n'a aucune d'équipe";
					}
				}
			} else {
				this.Result = "Minimum 2 joueurs";
			}
		}

		public void start()
		{

			Fight currentFight = new Fight(TeamsRegistered);

			// Affichage des équipes restantes
			foreach (Team t in currentFight.LstStillAlive)
			{
				Console.WriteLine("Winner: " + t.Name);
			}

			// Affichage de tous les champions morts
			Console.WriteLine("Champion - Equipe - Tués\n");
			string name;
			foreach (Team t in TeamsRegistered) {
				foreach (Champion c in t.ChampList) {
					name = c.Name;
					if (c.IsAlive == false)
						name += "*";
					Console.Write(name + "\t" + t.Name + "\t" + c.NbWin + "\n");
				}
			}
		}
	}
}

