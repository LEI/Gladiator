using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Dagger : Equipment, IOffense
	{

		public Dagger()
		{
			this.Name = "Dague";
			this.Weight = 2;
		}

		public double offense {
			get {
				return this.offense;
			}
			set {
				this.offense = 0.6;
			}
		}
	}
}

