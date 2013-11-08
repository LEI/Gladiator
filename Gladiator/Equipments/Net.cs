using System;
using Gladiator.Interfaces;
using Gladiator.Equipments;

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
               /* public Equipement testFilet(currentEquipment)
        {
                         // Tests filet
                   if ( currentEquipment is Net && currentEquipment.Used == true) {
						return result;
					}
					if (e is Net && currentEquipment.Used == false) {
						e.Used = true;
					}
        }*/
	}
}

