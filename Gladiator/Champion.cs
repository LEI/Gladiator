using System;
using System.Collections.Generic;
using Gladiator.Equipments;

namespace Gladiator
{
	public class Champion
	{
		private string _name;
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		private List<Equipment> _equipment = new List<Equipment>();
		public List<Equipment> Equipment
		{
			get { return this._equipment; }
			set { this._equipment = value; }
		}
		
		public Champion(string p_name)
		{
			this.Name = p_name;
		}

		public Champion(string p_name, List<Equipment> p_listEquipment)
		{
			this.Name = p_name;
			this.Equipment = p_listEquipment;
		}

		public void attack()
		{

		}

		public void defense()
		{

		}

		/*public Equipment equip()
		{
			this.ListEquip.Add (Dagger);
		}

		public static string myEquipment()
		{
			return "Je suis équipé de : " + this._listEquip + ". \n";
		}

		public GladiatorFighter(string p_name)
		{
			this.Name = p_name;
			equip ();

		}*/	 
	}
}

