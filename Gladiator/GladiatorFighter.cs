using System;
using System.Collections.Generic;
using Gladiator.Equipment;

namespace Gladiator
{
	public class GladiatorFighter
	{
		private string _name;
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		private List<Equipment> _listEquip = new List<Equipment> ();
		public List<Equipment> ListEquip
		{
			get { return this._listEquip; }
			set { this._listEquip = value; }
		}

		public void attack()
		{

		}

		public void defense()
		{

		}

		public Equipment equip()
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

		}	 
	}
}

