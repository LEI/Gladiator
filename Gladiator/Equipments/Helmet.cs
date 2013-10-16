using System;
using Gladiator.Interfaces;

namespace Gladiator.Equipments
{
	public class Helmet : Equipment, IDefense
	{
		public Helmet()
		{
			this.Name = "Casque";
			this.Weight = 2;
			this.Defense = 0.1;
		}
	}
}

