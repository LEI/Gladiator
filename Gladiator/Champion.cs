using System;
using System.Collections.Generic;
using Gladiator.Interfaces;
using Gladiator.Equipments;

namespace Gladiator
{
	public class Champion : IStats
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

		// Deuxieme constructeur : attend un nom et une liste d'items
		public Champion(string p_name, List<Equipment> p_itemList)
		{
			this.Name = p_name;
			this.ItemList = p_itemList;
		}

		public void addItem(Equipment p_item)
		{
			this.ItemList.Add(p_item);
		}

		public void attack()
		{
		
		}

		public void defend()
		{

		}
		
		protected int _nbWin = 0;
		public int NbWin
		{
			get { return this._nbWin; }
			set { this._nbWin = value; }
		}

		protected int _nbLose = 0;
		public int NbLose
		{
			get { return this._nbLose; }
			set { this._nbLose = value; }
		}

		protected int _nbDraw = 0;
		public int NbDraw
		{
			get { return this._nbDraw; }
			set { this._nbDraw = value; }
		}

		public double ratio()
		{
			return this.NbWin / this.NbLose;
		}
	}
}

