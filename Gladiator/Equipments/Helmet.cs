using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Helmet : Equipment, IDefense
	{
		public Helmet()
		{
			this.Name = "Casque";
			this.Weight = 2;
		}

		public double defense {
			get {
				return this.defense;
			}
			set {
				this.defense = 0.1;
			}
		}
	}
}

