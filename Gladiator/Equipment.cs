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

		protected int _priority;
		public int Priority
		{
			get {
				return this._priority;
			}
			set {
				this._priority = value;
			}
		}

		protected double _offense;
		public double Offense
		{
			get {
				return this._offense;
			}
			set {
				this._offense = value;
			}
		}

		protected double _defense;
		public double Defense
		{
			get {
				return this._defense;
			}
			set {
				this._defense = value;
			}
		}

		private bool _used = false;
		public bool Used 
		{
			get { return this._used; }
			set { 

								this._used = value;
			 }
		}


	}
}

