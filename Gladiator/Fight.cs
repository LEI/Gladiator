using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Fight
	{
		public Fight(List<Team> teamsRegistered)
		{
			sortTeams(teamsRegistered);
			showTeams(teamsRegistered);
			// Initialisation des duels et affichage des équipes
			// !!!! Tournoi ? -> générer d'autres matchs ?

			// Premier duel
			List<Team> stillAlive = initDuels(teamsRegistered);
			// Relance duel tant qu'il reste plus d'une équipe
			while (stillAlive.Count > 1) {
				stillAlive = initDuels(stillAlive);
			}

			Console.WriteLine("ALLO");
			// Affichage des équipes restantes
			foreach (Team t in stillAlive)
			{
				Console.WriteLine("winner: " + t.Name);
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

		public List<Team> initDuels(List<Team> p_teamsRegistered)
		{
			List<Team> winners = new List<Team>();
			Duel currentDuel;
			for (int i=0; i < p_teamsRegistered.Count-1; i += 2) {
				Console.WriteLine("\n---------- MATCH : " + p_teamsRegistered[i].Name + " VS " + p_teamsRegistered[i+1].Name + " ----------");
				currentDuel = new Duel(p_teamsRegistered[i], p_teamsRegistered[i + 1]);
                if (currentDuel.StillAlive != null)
                {
                    winners.Add(currentDuel.StillAlive);
                }

				// !!!!! Calculer le nombre de victoires pendant l'exécution pour afficher les vainqueurs
				//Console.WriteLine("\n" + winner.Name + " gagne avec " + winner.NbWin + " victoires");
			}
			// Retourne la liste des équipes vivantes après la série de duels
			return winners;
		}

		public void showTeams(List<Team> p_teamsRegistered)
		{
			// Affichage des équipes
			Console.WriteLine("----- EQUIPES EN LICE -----");
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

