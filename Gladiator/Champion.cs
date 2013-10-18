using System;
using System.Collections.Generic;
using Gladiator.Interfaces;
using Gladiator.Equipments;
using System.Linq;

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

		private bool _isCapture = false;
		public bool IsCapture {
			get { return this._isCapture; }
			set { this._isCapture = value; }
		}
		
		private Random rand = new Random();
		public Random Rand {
			get { return this.rand; }
			set { this.rand = value; }
		}

		public Champion(string p_name)
		{
			this.Name = p_name;
		}

		// Deuxieme constructeur : nom et liste d'items
		public Champion(string p_name, List<Equipment> p_itemList)
		{
			this.Name = p_name;
			this.ItemList = p_itemList;
		}

		public void sortItems(List<Equipment> p_itemList)
		{
			int i = 0;

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
		}

		public void addItem(Equipment p_item)
		{

			if (this.StuffWeight + p_item.Weight <= 10) {
				this.ItemList.Add(p_item);
				this.StuffWeight += p_item.Weight;
				// Tri par priorité
				sortItems(this.ItemList);
			} else
				Console.WriteLine (this.Name + " ne peut pas porter l'équipement " + p_item.Name + ", " + (10 - this.StuffWeight) + " points restant");
		}

		public void deleteItem(Equipment p_item)
		{
			this.StuffWeight -= p_item.Weight;
			this.ItemList.Remove(p_item);
			Console.WriteLine (this.Name + " jette l'équipement " + p_item.Name + ", " + (10 - this.StuffWeight) + " points restant");
		}

		public string attack(Champion p_adv, int p_priority)
		{
			string result = null;
			int coef = 1;

			List<Equipment> l_lstEquiPrio = (from b_equipement in this.ItemList
			                                 where b_equipement.Priority == p_priority
			                                 select b_equipement).ToList();

				foreach (Equipment e in l_lstEquiPrio) {
				// Probabilité de toucher
				if (e.Priority == p_priority) {
					if ( e is Net && e.Priority == 5 && e.Used == true) {
						return result;
					}

					if ( e.Priority == 5 && e.Used == false) {
						e.Used = true;
					} 

					result += this.Name + " utilise " + e.Name + " (" + e.Priority + ")\n";
					if (this.IsCapture == true) {
						coef = 2;
						result += this.Name + " est pris dans les mailles du filet \n";
					}
					if (Rand.NextDouble() < e.Offense / coef) {
						if (e is Net) {
							p_adv.IsCapture = true;
							result += "* " + this.Name + " capture " + p_adv.Name + "\n";
							return result;
						}
						result += "* " + this.Name + " touche " + p_adv.Name + "\n";
						bool hit = p_adv.defend();
						if (hit == true) {
							result += " -> COUP MORTEL \n";
			
							p_adv.IsAlive = false;
							p_adv.IsCapture = false;
							this.IsCapture = false;
						} else {
							result += " -> PARADE \n";
						}
					} else {
						result += "* " + this.Name + " manque " + p_adv.Name + "\n";
					}
				}
			}
			return result;
		}

		public bool defend()
		{
			bool hit = true;
			foreach (Equipment e in this.ItemList) {
				// Traitement des équipements défensifs
				if (e is IDefense) {
					// Probabilité de parer
					if (this.Rand.NextDouble() < e.Defense) {
						return hit = false;
					}
				}
			}

			return hit;
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

