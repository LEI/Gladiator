using System;
using System.Collections.Generic;
using Gladiator.Interfaces;

namespace Gladiator
{
	public class Team : IStats
	{
		private string _name;
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		private string _description;
		public string Description
		{
			get { return this._description; }
			set { this._description = value; }
		}

		private List<Champion> _champList = new List<Champion>();
		public List<Champion> ChampList
		{
			get { return this._champList; }
			set { this._champList = value; }
		}

		public Team(string p_name, string p_description)
		{
			this.Name = p_name;
			this.Description = p_description;
		}

		public void addChampion(Champion p_champion)
		{
			this.ChampList.Add(p_champion);
		}

		public void deleteGladiator(Champion p_champion)
		{
			this.ChampList.Remove(p_champion);

		}

		public void chooseOrder()
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
	}
}

