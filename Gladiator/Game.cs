using System;

namespace Gladiator
{
	public class Game
	{
		private Player _player1;
		public Player Player1
		{
			get { return this._player1; }
			set { this._player1 = value; }
		}

		private Player _player2;
		public Player Player2
		{
			get { return this._player2; }
			set { this._player2 = value; }
		}

		public Game(Player p1, Player p2)
		{
			// Initialisation du jeu
			this.Player1 = p1;
			this.Player2 = p2;
		}

		public string start()
		{
			return this.Player1.getFullName() + " VS " + this.Player2.getFullName();

			// Sélection équipes
		}
	}
}

