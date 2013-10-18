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
			if (t_players.Length > 1) {
				foreach (Player p in t_players) {
					// Vérification du nombre d'équipes
					if (p.TeamList.Count > 0) {
						TeamsRegistered.Add(p.TeamList[0]);
					} else {
						throw new Exception("Le joueur " + p.Alias + " n'a aucune d'équipe");
					}
				}
			} else {
				throw new Exception("Minimum 2 joueurs");
			}
		}

		public void start()
		{
			new Fight(TeamsRegistered);
		}
	}
}

