using System;

namespace Gladiator
{
	public class Duel
	{
		private Champion _champion1;
		public Champion Champion1
		{
			get { return this._champion1; }
			set { this._champion1 = value; }
		}

		private Champion _champion2;
		public Champion Champion2
		{
			get { return this._champion2; }
			set { this._champion2 = value; }
		}

		public Duel(Champion c1, Champion c2)
		{
			this.Champion1 = c1;
			this.Champion2 = c2;
		}
	}
}

