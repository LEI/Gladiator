using System;
using Gladiator.Interfaces;

namespace Gladiator
{
	public class SmallRoundedShield : Equipment, IDefense
	{
		public SmallRoundedShield()
		{
			this.Name = "Petit bouclier rond";
			this.Weight = 5;
			this.Defense = 0.2;
			this.Priority = 0;
		}
	}
}

