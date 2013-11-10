using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Game
	{
		/*private string _result;
		public string Result
		{
			get { return this._result; }
			set { this._result = value; }
		}*/

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
			if (t_players.Length > 1 && ((t_players.Length / 2)%2 == 0)) {
				foreach (Player p in t_players) {
					// Vérification du nombre d'équipes et du nombre de leur nombre de champions
					if (p.TeamList.Count > 0) {
						foreach (Team t in p.TeamList) {
							if (t.ChampList.Count == 3) {
								TeamsRegistered.Add(t);
							} else {
								Console.WriteLine("L'équipe " + t.Name + " doit comporter 3 gladiateurs");
							}
						}
					} else {
						Console.WriteLine("Le joueur " + p.Alias + " n'a pas d'équipe");
					}
				}
			} else {
				Console.WriteLine("Minimum 2 joueurs, le nombre total doit être une puissance de 2");
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
		}
	}
}

