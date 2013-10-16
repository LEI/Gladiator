using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class RectangularShield : Equipment, IDefense
	{
		public RectangularShield()
		{
			this.Name = "Bouclier rectangluaire";
			this.Weight = 2;
			this.Defense = 0.6;
		}
	}
}

