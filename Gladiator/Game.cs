using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Game
	{
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
			if ((t_players.Length / 2) %  2 == 0 ) {
				foreach (Player p in t_players) {
					// Vérification du nombre d'équipes
					if (p.TeamList.Count > 0) {
						TeamsRegistered.Add(p.TeamList[0]);
					} else {
						throw new Exception("Le joueur " + p.Alias + " n'a aucune d'équipe");
					}
				}
			} else {
				throw new Exception("Pour jouer en tournoi il faut un nombre d'équipe valant une puissance de deux. (2, 4, 8, 16...");
			}
		}

		public void start()
		{

			new Fight(TeamsRegistered);

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

