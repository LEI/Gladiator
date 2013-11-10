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
			// Mise à jour des stats
			if (c1.IsAlive == false && c2.IsAlive == true) {
				c2.NbWin++;
				c1.NbLose++;
			} else if (c1.IsAlive == true && c2.IsAlive == false) {
				c1.NbWin++;
				c2.NbLose++;
			} else if (c1.IsAlive == false && c2.IsAlive == false) {
				c1.NbDraw++;
				c2.NbDraw++;
			}
		}
        // Méthode appelée à chaque appel de round, elle retourne tous le déroulement de la joute.
        //  Elle continue jusqu'à ce que mort s'en suive et qu'un nouveau gladiateur entre dans l'arene.
		public string fightToDeath(Champion c1, Champion c2)
		{
			string result = "";
			string attack1 = null;
			string attack2 = null;
            // Tant que les deux sont vivants.
			while(c1.IsAlive & c2.IsAlive ) {
				for (int priority = 5; priority >= 1 & c1.IsAlive & c2.IsAlive ; priority--) {
					// Combat de même priorité
					attack1 = c1.attack(c2, priority);	
					attack2 = c2.attack(c1, priority);
					// Affichage du résultat du combat en couleur
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

