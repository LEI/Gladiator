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
			//  Si il n'y as que deux joueur et que l'un d'eux n'a pas d'equipe = PLANTAGE
			if (t_players.Length > 1) {
				// Initialisation du jeu, traitement minimum de joueur
				foreach (Player p in t_players) {
					if (p.TeamList.Count > 0) {
						TeamsRegistered.Add(p.TeamList[0]);
					} else {
						throw new Exception("Erreur le joueur : " + p.Alias + " n'a pas d'équipe !");
						// Le joueur n'a pas d'equipe donc il faut la creer pour jouer.
					}
				}
			}
			else
				throw new Exception("Erreur il faut au minimum 2 joueurs.");
		}

		public void start()
		{
			new Fight(TeamsRegistered);
			// Sélection équipes en fonction de Team.ratio()
		}
	}
}

