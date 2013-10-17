using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Round
	{
		public Round(Champion c1, Champion c2)
		{
			List<Champion> round = new List<Champion>();
			round.Add(c1);
			round.Add(c2);

			List<Champion> deadList = Champion.attack(round);

			foreach (Champion c in deadList) {
				c.IsAlive = false;
				Console.WriteLine(c.Name + " est mort");
			}



		}
	}
}

