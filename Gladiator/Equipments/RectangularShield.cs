using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class RectangularShield : Equipment, IDefense
	{
		public RectangularShield()
		{
			this.Name = "Bouclier rectangluaire";
			this.Weight = 2;
		}

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

