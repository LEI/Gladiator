using System;

namespace Gladiator
{
	public class Round
	{
		public Round(Champion c1, Champion c2)
		{

			// ON EN AI LAAAAAAAAAAAAAAA
			if (c1.attack(c2)) {
				Console.WriteLine("C1 ATTAQUE");
				c2.IsAlive = false;
			}
			if (c2.attack(c1)) {
				Console.WriteLine("C2 ATTAQUE");
				c1.IsAlive = false;
			}
			c2.IsAlive = false;

			 // if...



		}
	}
}

