using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipment
{
	public class Dagger : Equipment, IOffense
	{
		public double offense {
			get {
				return this.offense;
			}
			set {
				this.offense = 0.6;
			}
		}
	


		private string Name = "Dague";

		private int _weight = 2;
	}
}

