using System;

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
	}
}

