using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Net : Equipment, IOffense
	{
		private string Name = "Filet";
		private int Weight = 3;

		public double offense {
			get {
				return this.offense;
			}
			set {
				this.offense = 0.3;
			}
		}
	}
}

