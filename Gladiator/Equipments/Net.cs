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
			this.Offense = 0.3;
			this.Priority = 5;
			this.Used = false;
		}
	}
}

