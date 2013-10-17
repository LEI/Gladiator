using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Sword : Equipment, IOffense
	{
		public Sword()
		{
			this.Name = "Épée";
			this.Weight = 5;
			this.Offense = 0.7;
		}
	}
}

