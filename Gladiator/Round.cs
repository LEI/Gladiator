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
				Console.WriteLine(c1.Name + " est mort "/*(" + c1.NbWin + " - " + c1.NbLose + ")"*/);
			}
			if (c2.IsAlive == false) {
				c2.NbLose++;
				c1.NbWin++;
				Console.WriteLine(c2.Name + " est mort "/*(" + c2.NbWin + " - " + c2.NbLose + ")"*/);
			}

		}
	}
}

