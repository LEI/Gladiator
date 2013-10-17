using System;
using Gladiator.Interfaces;

namespace Gladiator
{
	public class SmallRoundedShield : Equipment, IDefense
	{
		public SmallRoundedShield()
		{
			this.Name = "Petit Bouclier rond";
			this.Weight = 5;
			this.Defense = 0.2;
		}
	}
}

