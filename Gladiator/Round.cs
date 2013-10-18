using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Round
	{



		public Round(Champion c1, Champion c2)
		{
			string result1 = null;
			string result2 = null;

			while(c1.IsAlive & c2.IsAlive ) {

				for (int priority = 5; priority >= 1 & c1.IsAlive & c2.IsAlive ; priority--) {


					result1 = c1.attack(c2, priority);	
					result2 = c2.attack(c1, priority);

					if (result1 != null)
					Console.WriteLine(result1);
					if (result2 != null)
					Console.WriteLine(result2);
				}
			}


			if (c1.IsAlive == false) {
				c1.NbLose++;
				c2.NbWin++;
				Console.WriteLine(c1.Name + " est mort T_T (" + c1.NbWin + " - " + c1.NbLose + ")");
			}
			if (c2.IsAlive == false) {
				c2.NbLose++;
				c1.NbWin++;
				Console.WriteLine(c2.Name + " c'est fait trucider T_T (" + c2.NbWin + " - " + c2.NbLose + ")");
			}

		}
		
		/*public bool attack(Champion p_champ)
		{
			bool alive = true;
			// Probabilité de toucher
			if (rand.NextDouble() < this.ItemList[0].Priority) {
				Console.WriteLine(this.Name + " HIT " + p_champ.Name);
				if(!p_champ.defend())
					alive = false;
			} else {
				Console.WriteLine(this.Name + " MISS " + p_champ.Name);
			}
			//this.ItemList;

			return alive;
		}*/

		/*
		public static List<Champion> attack(List<Champion> p_list)
		{
			List<Champion> deadList = new List<Champion>();

			foreach (Champion c in p_list) {
				// Probabilité de toucher
				if (c.Rand.NextDouble() < c.ItemList[0].Priority) {
					Console.WriteLine(c.Name + " HIT ");
					if (!c.defend()) {
						Console.WriteLine("CRITICAL HIT");
						deadList.Add(c);
					} else {
						Console.WriteLine("ATTACK BLOCKED");
					}
				} else {
					Console.WriteLine(c.Name + " MISS ");
				} 
				//this.ItemList;
			}

			return deadList;
		}*/



	}
}

