using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Fight
	{
		private List<Team> _lstStillALive;
		public List<Team> LstStillAlive
		{
			get { return this._lstStillALive; }
			set { this._lstStillALive = value; }
		}

		public Fight(List<Team> teamsRegistered)
		{
			sortTeams(teamsRegistered);
			showTeams(teamsRegistered);
			// Initialisation des matchs et affichage des équipes
			// !!!! Tournoi ? -> générer d'autres matchs ?

			// Premier match
			LstStillAlive = initMatch(teamsRegistered);
			// Relance match tant qu'il reste plus d'une équipe
			while (LstStillAlive.Count > 1) {
				LstStillAlive = initMatch(LstStillAlive);
			}
		}

		public void sortTeams(List<Team> p_teamsRegistered)
		{
			int i = 0;
			// Tri des teams en fonction de leur ratio
			while (i < p_teamsRegistered.Count-1)
			{
				if (p_teamsRegistered[i].ratio() < p_teamsRegistered[i + 1].ratio()) {
					SortList.Swap<Team>(p_teamsRegistered, i, i + 1);
					i = 0;
				} else
					i++;
			}
		}

		public List<Team> initMatch(List<Team> p_teamsRegistered)
		{
			List<Team> winners = new List<Team>();
			Match currentMatch;
			for (int i=0; i < p_teamsRegistered.Count-1; i += 2) {
				Console.WriteLine("\n---------- MATCH : " + p_teamsRegistered[i].Name + " VS " + p_teamsRegistered[i+1].Name + " ----------");
				currentMatch = new Match(p_teamsRegistered[i], p_teamsRegistered[i + 1]);
                Console.WriteLine(currentMatch.ResultMatch);
				if (currentMatch.StillAlive != null)
                {
					winners.Add(currentMatch.StillAlive);
                }
			}
			// Retourne la liste des équipes vivantes après la série de matchs
			return winners;
		}

		public void showTeams(List<Team> p_teamsRegistered)
		{
			// Affichage des équipes
			Console.WriteLine("---------- EQUIPES EN LICE ----------");
			foreach (Team t in p_teamsRegistered) {
				Console.WriteLine("\n" + t.Name + " (" + t.NbWin + "/" + t.NbLose + ")\n");
				foreach (Champion c in t.ChampList) {
					Console.WriteLine("\t" + c.Name + " (" + c.NbWin + "/" + c.NbLose + ")");
					foreach (Equipment e in c.ItemList) {
						Console.WriteLine("\t\t" + e.Name + " (" + e.Priority + ")");
					}
				}
			}
		}
	}
}

