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
			// Vérification du nombre de joueur
			if (t_players.Length > 1 && ((t_players.Length / 2)%2 == 0)) {
				foreach (Player p in t_players) {
					// Vérification du nombre d'équipes et du nombre de leur nombre de champions
					if (p.TeamList.Count > 0) {
						// Ajout de la première équipe
						foreach (Team t in p.TeamList) {
							if (t.ChampList.Count == 3) {
								TeamsRegistered.Add(t);
								break;
							} else {
								Console.WriteLine("L'équipe " + t.Name + " doit comporter 3 gladiateurs pour être éligible");
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
				Console.WriteLine("\n* L'équipe " + t.Name + " remporte la partie");
			}
		}
	}
}

