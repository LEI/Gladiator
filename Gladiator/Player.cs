using System;

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




	}
}

