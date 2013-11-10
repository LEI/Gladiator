using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Trident : Equipment, IOffense, IDefense
	{
		public Trident()
		{
			this.Name = "Trident";
			this.Weight = 7;
			this.Offense = 0.4;
			this.Defense = 0.1;
			this.Priority = 3;
		}
	}
}


