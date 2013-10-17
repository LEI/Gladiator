using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Fight
	{
		private Team _team1;
		public Team Team1
		{
			get { return this._team1; }
			set { this._team1 = value; }
		}


		public Fight(List<Team> p_teams)
		{

		}
	}
}

