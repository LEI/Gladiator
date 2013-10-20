using System;
using Gladiator.Interfaces;
using Gladiator.Equipments;

namespace Gladiator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Player p1 = new Player("Doe", "John", "DJ");
			Player p2 = new Player("Roe", "Jane", "RJ");
			Player p3 = new Player("Save", "Nico", "BG");
			Player p4 = new Player("NRV", "Gui", "LEI");

			Team t1 = new Team("Aye", "lol");
			Team t2 = new Team("Bye", "lol");
			Team t3 = new Team("Cye", "lol");
			Team t4 = new Team("Dye", "lol");

			t1.NbWin = 6;
			t1.NbLose = 3;
			t2.NbWin = 8;
			t2.NbLose = 3;
			t3.NbWin = 10;
			t3.NbLose = 3;
			t4.NbWin = 2;
			t4.NbLose = 3;
			
			p1.addTeam(t1);
			p2.addTeam(t2);
			p3.addTeam(t3);
			p4.addTeam(t4);

			Champion c1 = new Champion("AONE");
			Champion c2 = new Champion("ADUO");
			Champion c3 = new Champion("ATRI");

			Champion c4 = new Champion("BONE");
			Champion c5 = new Champion("BDUO");
			Champion c6 = new Champion("BTRI");

			Champion c7 = new Champion("CONE");
			Champion c8 = new Champion("CDUO");
			Champion c9 = new Champion("CTRI");

			Champion c10 = new Champion("DONE");
			Champion c11 = new Champion("DUOD");
			Champion c12 = new Champion("DTRI");

			t1.addChampion(c1);
			t1.addChampion(c2);
			t1.addChampion(c3);

			t2.addChampion(c4);
			t2.addChampion(c5);
			t2.addChampion(c6);

			t3.addChampion(c7);
			t3.addChampion(c8);
			t3.addChampion(c9);

			t4.addChampion(c10);
			t4.addChampion(c11);
			t4.addChampion(c12);

			Equipment dague = new Dagger();
			Equipment casque = new Helmet();
			Equipment filet = new Net();
			Equipment filet2 = new Net();
			Equipment filet3 = new Net();
			Equipment trident = new Trident();
			Equipment epee = new Sword();
			Equipment lance = new Spear();
			Equipment bouclierRect = new RectangularShield();
			Equipment bouclierRond = new SmallRoundedShield();

			c1.addItem(dague);
			c1.addItem(epee);

			c2.addItem(epee);
			c2.addItem(bouclierRond);

			c3.addItem(dague);
			c3.addItem(filet);

			c4.addItem(trident);
			c4.addItem(dague);

			c5.addItem(epee);
			c5.addItem(bouclierRond);

			c6.addItem(filet2);
			c6.addItem(dague);

			c7.addItem(trident);
			c7.addItem(casque);
					   
			c8.addItem(casque);
			c8.addItem(lance);
					   
			c9.addItem(filet3);
			c9.addItem(dague);

			c10.addItem(lance);
			c10.addItem(dague);
						
			c11.addItem(dague);
			c11.addItem(bouclierRect);
						
			c12.addItem(casque);
			c12.addItem(bouclierRond);

			// Modification de l'ordre des champions :
			//SortList.Swap<Champion>(t1.ChampList, 1, 2);

			Game newGame = new Game(p1, p2, p3);
			newGame.start();
		}
	}
}
