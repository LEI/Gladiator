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

		private List<Equipment> _itemList = new List<Equipment>();
		public List<Equipment> ItemList
		{
			get { return this._itemList; }
			set { this._itemList = value; }
		}
		
		public Champion(string p_name)
		{
			this.Name = p_name;
		}

		public Champion(string p_name, List<Equipment> p_itemList)
		{
			this.Name = p_name;
			this.ItemList = p_itemList;
		}

		public void addItem(Equipment p_item)
		{
			this.ItemList.Add(p_item);
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

		
		public void attack()
		{

		}

		public void defense()
		{

		}
	}
}
