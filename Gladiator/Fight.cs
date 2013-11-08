using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Fight
	{
		public Fight(List<Team> p_teamsRegistered)
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
			// Initialisation des duels et affichage des équipes
			// !!!! Tournoi ? -> générer d'autres matchs ?
			List<Team> winners = new List<Team>();
            Duel currentDuel;
			for (i=0; i < p_teamsRegistered.Count-1; i += 2) {
				Console.WriteLine("\n---------- MATCH : " + p_teamsRegistered[i].Name + " VS " + p_teamsRegistered[i+1].Name + " ----------");
				currentDuel = new Duel(p_teamsRegistered[i], p_teamsRegistered[i + 1]);
				winners.Add(currentDuel.winners.StillAlive);

				/*if (p_teamsRegistered[i].NbWin > p_teamsRegistered[i+1].NbWin)
					winner = p_teamsRegistered[i];
				else
					winner = p_teamsRegistered[i+1];
				*/
				
				foreach (Team t in winners) {
					Console.WriteLine("winner: " + t.Name);
				}

				// !!!!! Calculer le nombre de victoires pendant l'exécution pour afficher les vainqueurs
				//Console.WriteLine("\n" + winner.Name + " gagne avec " + winner.NbWin + " victoires");
			}

		}
	}
}

