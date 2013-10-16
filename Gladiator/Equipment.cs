using System;

namespace Gladiator
{
	public abstract class Equipment
	{
		public object offense {
			get;
			set;
		}

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

	}
}

