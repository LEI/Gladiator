using System;
using System.Collections.Generic;

namespace Gladiator
{
	public static class SortList
	{
        // M�thode permetant d'�changer deux �l�ments d'une liste.
		public static void Swap<T>(this List<T> list, int index1, int index2)
		{
			T temp = list[index1];
			list[index1] = list[index2];
			list[index2] = temp;
		}
	}
}

