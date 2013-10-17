using System;
using System.Collections.Generic;
using Gladiator.Interfaces;
using Gladiator.Equipments;

namespace Gladiator
{
	public class Champion : IStats
	{
		private int _stuffWeight = 0;
		public int StuffWeight
		{
			get { return this._stuffWeight; }
			set { this._stuffWeight = value; }
		}
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
			set { 
				// Ordre des items
				this._itemList = value; }
		}

		private bool _isAlive = true;
		public bool IsAlive {
			get { return this._isAlive; }
			set { this._isAlive = value; }
		}

		private Random rand = new Random();

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

		public void sortItems(List<Equipment> p_itemList)
		{
			int i = 0;


			foreach (Equipment e in p_itemList) {
				Console.WriteLine( this.Name + "BEFORE : " + e.Name + e.Priority.ToString());
			}

			if (p_itemList.Count > 1) {
				while (i < p_itemList.Count - 1) {
					// Tri des teams en fonction de leur ratio
					if (p_itemList[i].Priority < p_itemList[i + 1].Priority) {
						Equipment temp = p_itemList[i];
						p_itemList[i] = p_itemList[i + 1];
						p_itemList[i + 1] = temp;
						i = 0;
					} else {
						i++;
					}
				}
			}

			foreach (Equipment e in p_itemList) {
				Console.WriteLine(this.Name + "AFTER : " + e.Name + e.Priority.ToString());
			}
		}

		public void addItem(Equipment p_item)
		{

			if (this.StuffWeight + p_item.Weight <= 10) {
				this.ItemList.Add(p_item);
				this.StuffWeight += p_item.Weight;
				sortItems(this.ItemList);
			} else
				Console.WriteLine ("Vous n'avez pas assez de place pour cet objet. Place dispo : " + (10 - this.StuffWeight) + ".");
				// TRIE A CHAQUE AJOUT D'ITEM PAR PRIORITE
		}

		public void deleteItem(Equipment p_item)
		{
			this.StuffWeight -= p_item.Weight;
			this.ItemList.Remove(p_item);
			Console.WriteLine ("Place dispo : " + (10 - this.StuffWeight) + ".");
		}

		public bool attack(Champion adv)
		{
			bool state = false;

			//this.ItemList;

			return state;
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
			return (this.NbWin * 100 / (this.NbLose + this.NbWin + this.NbDraw));
		}
	}
}

