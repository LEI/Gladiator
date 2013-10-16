using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Team
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

		public void Register()
		{

		}

		public void AddGladiator(Champion p_champion)
		{
			this.ChampList.Add(p_champion);
		}

		public void DeleteGladiator(Champion p_champion)
		{
			this.ChampList.Remove(p_champion);

		}

		public void ChooseOrder()
		{

		}
	}
}

