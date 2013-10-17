using System;
using Gladiator.Interfaces;

namespace Gladiator
{
	public abstract class Equipment
	{
		protected string _name;
		public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}

		protected int _weight;
		public int Weight
		{
			get { return this._weight; }
			set { this._weight = value; }
		}

		protected double offense;
		public double Offense
		{
			get {
				return this.offense;
			}
			set {
				this.offense = value;
			}
		}

		protected double defense;
		public double Defense
		{
			get {
				return this.defense;
			}
			set {
				this.defense = value;
			}
		}
	}
}

