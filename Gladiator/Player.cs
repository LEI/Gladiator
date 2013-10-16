using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Player
	{
		private string _name;
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		private string _firstname;
		public string Firstname
		{
			get { return this._firstname; }
			set { this._firstname = value; }
		}

		private string _alias;
		public string Alias
		{
			get { return this._alias; }
			set { this._alias = value; }
		}

		private DateTime _addDate;
		public DateTime AddDate
		{
			get { return this._addDate; }
			set { this._addDate = DateTime.Now; }
		}

		private List<Team> _teamList = new List<Team>();
		public List<Team> TeamList
		{
			get { return this._teamList; }
			set { this._teamList = value; }
		}

		public Player(string p_name, string p_firstname, string p_alias)
		{
			this.Name = p_name;
			this.Firstname = p_firstname;
			this.Alias = p_alias;
			this.AddDate = DateTime.Now;
		}

		public string getFullName()
		{
			string fullName = this.Firstname + " '" + this.Alias + "' " + this.Name;
			//this.FullName = fullName;
			return fullName;
		}

		public string AddTeam(Team p_team)
		{
			if (this.TeamList.Count < 6) {
				this.TeamList.Add(p_team);
				return p_team.Name + " added";
			} else {
				return p_team.Name + " not added, 5 teams maximum";
			}
		}

		public void DeleteTeam(Team p_team)
		{
			this.TeamList.Remove(p_team);
		}

	}
}

