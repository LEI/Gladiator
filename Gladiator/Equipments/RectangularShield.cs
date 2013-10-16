using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class RectangularShield : Equipment, IDefense
	{
		private string Name = "Bouclier rectangluaire";
		private int Weight = 2;

		public double defense {
			get {
				return this.defense;
			}
			set {
				this.defense = 0.6;
			}
		}
	}
}

