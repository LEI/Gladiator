using System;

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
		
		private Team _team2;
		public Team Team2
		{
			get { return this._team2; }
			set { this._team2 = value; }
		}

		public Fight(Team t1, Team t2)
		{
			this.Team1 = t1;
			this.Team2 = t2;
		}
	}
}

