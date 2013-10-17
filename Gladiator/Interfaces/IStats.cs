using System;

namespace Gladiator.Interfaces
{
	public interface IStats
	{
		int NbWin { get; set; }
		int NbLose { get; set; }
		int NbDraw { get; set; }
	}
}

