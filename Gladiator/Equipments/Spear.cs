using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Spear : Equipment, IOffense
	{
		public Spear()
		{
			this.Name = "Lance";
			this.Weight = 7;
			this.Offense = 0.5;
			this.Priority = 4;
		}
	}
}

