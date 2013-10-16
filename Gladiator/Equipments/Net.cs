using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Net : Equipment, IOffense
	{
		public Net()
		{
			this.Name = "Filet";
			this.Weight = 3;
		}

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

