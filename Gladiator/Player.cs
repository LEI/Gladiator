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
			set
			{
				//if (value == String.Empty)
				this._name = value;
			}
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
			set
			{
				// Vérification à faire au moment de l'ajout addTeam()     (impossible dans set?)
				if (value.Count > 5)
				{
					this._teamList = new List<Team>();
				}
				this._teamList = value;
			}
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
			return this.Firstname + " '" + this.Alias + "' " + this.Name;
		}

		public void addTeam(Team p_team)
		{
			this.TeamList.Add(p_team);
		}

		public void deleteTeam(Team p_team)
		{
			this.TeamList.Remove(p_team);
		}
	}
}

