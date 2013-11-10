using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Round
	{
		private string _result;
		public string Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public Round(Champion c1, Champion c2)
		{
			this.Result = fightToDeath(c1,c2);

			if (c1.IsAlive == false) {
				c1.NbLose++;
				c2.NbWin++;
				//Console.WriteLine(c1.Name + " est mort ");
			}
			if (c2.IsAlive == false) {
				c2.NbLose++;
				c1.NbWin++;
				//Console.WriteLine(c2.Name + " est mort ");
			}
		}

		public string fightToDeath(Champion c1, Champion c2)
		{
			string result = "";
			string attack1 = null;
			string attack2 = null;

			while(c1.IsAlive & c2.IsAlive ) {
				for (int priority = 5; priority >= 1 & c1.IsAlive & c2.IsAlive ; priority--) {
					// Combat de même priorité
					attack1 = c1.attack(c2, priority);	
					attack2 = c2.attack(c1, priority);
					// Affichage du résultat du combat
					/*if (attack1 != null) {
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(attack1);
						Console.ResetColor();
					}
					if (attack2 != null) {
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine(attack2);
						Console.ResetColor();
					}*/
					if (attack1 != null && attack2 != null) {
						result += attack1 + attack2;
					} else if (attack1 != null && attack2 == null) {
						result += attack1;
					} else if (attack2 != null && attack1 == null) {
						result += attack2;
					}
				}
			}

			return result;
		}
	}
}

