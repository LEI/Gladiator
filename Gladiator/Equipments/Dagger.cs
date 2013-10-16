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
			this.Offense = 0.6;
		}
	}
}

