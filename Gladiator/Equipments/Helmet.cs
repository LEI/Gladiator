using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Helmet : IDefense
	{
		private string Name = "Casque";
		private int Weight = 2;

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

