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
			while (i < p_teamsRegitered.Count-1)
			{
				// Tri des teams en fonction de leur ratio
				if (p_teamsRegitered[i].ratio() < p_teamsRegitered[i + 1].ratio()) {
					swapTeam(p_teamsRegitered, i, i + 1);
					i = 0;
				} else
					i++;
			}
			for (i=0; i < p_teamsRegitered.Count-1; i += 2) {
				Console.WriteLine("\n----- MATCH : " + p_teamsRegitered[i].Name + "(" + p_teamsRegitered[i].NbWin + "/"+ p_teamsRegitered[i].NbLose + ") VS " + p_teamsRegitered[i+1].Name + "(" + p_teamsRegitered[i+1].NbWin + "/"+ p_teamsRegitered[i+1].NbLose + ") -----");
				new Duel(p_teamsRegitered[i], p_teamsRegitered[i+1]);
				Console.WriteLine(p_teamsRegitered[i].Name + " a remporté " + p_teamsRegitered[i].NbWin + " matchs");
				Console.WriteLine(p_teamsRegitered[i+1].Name + " a remporté " + p_teamsRegitered[i+1].NbWin + " matchs");
			}

		}
	}
}

