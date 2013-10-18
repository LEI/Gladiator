using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Fight
	{
		public void swapTeam(List<Team> l_team, int index1, int index2)
		{
			Team temp = l_team[index1];
			l_team[index1] = l_team[index2];
			l_team[index2] = temp;
		}

		public Fight(List<Team> p_teamsRegitered)
		{
			int i = 0;
			// Tri des teams en fonction de leur ratio
			while (i < p_teamsRegitered.Count-1)
			{
				if (p_teamsRegitered[i].ratio() < p_teamsRegitered[i + 1].ratio()) {
					swapTeam(p_teamsRegitered, i, i + 1);
					i = 0;
				} else
					i++;
			}
			// Affichage des équipes
			Console.WriteLine("----- EQUIPES EN LICE -----");
			foreach (Team t in p_teamsRegitered) {
				Console.WriteLine("\n" + t.Name + " (" + t.NbWin + "/" + t.NbLose + ")\n");
				foreach (Champion c in t.ChampList) {
					Console.WriteLine("\t" + c.Name + " (" + c.NbWin + "/" + c.NbLose + ")");
					foreach (Equipment e in c.ItemList) {
						Console.WriteLine("\t\t" + e.Name + " (" + e.Priority + ")");
					}
				}
			}
			// Initialisation des duels et affichage des équipes
			Team winner;
			for (i=0; i < p_teamsRegitered.Count-1; i += 2) {
				Console.WriteLine("\n----- MATCH : " + p_teamsRegitered[i].Name + " VS " + p_teamsRegitered[i+1].Name + " -----");
				new Duel(p_teamsRegitered[i], p_teamsRegitered[i+1]);

				if (p_teamsRegitered[i].NbWin > p_teamsRegitered[i+1].NbWin)
					winner = p_teamsRegitered[i];
				else
					winner = p_teamsRegitered[i+1];

				Console.WriteLine(winner.Name + " gagne avec " + winner.NbWin + " victoires");
			}

		}
	}
}

