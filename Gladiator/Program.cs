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
			Player p4 = new Player("Gui", "LEI", "NRV");

			Team t1 = new Team("A", "lol");
			Team t2 = new Team("B", "lol");
			Team t3 = new Team("C", "lol");
			Team t4 = new Team("D", "lol");

			t1.NbWin = 6;
			t1.NbLose = 3;
			t2.NbWin = 8;
			t2.NbLose = 3;
			t3.NbWin = 10;
			t3.NbLose = 3;
			t4.NbWin = 2;
			t4.NbLose = 3;

			p1.addTeam(t1);
			//p3.addTeam(t3);

			p2.addTeam(t2);
			//p4.addTeam(t4);



			Champion c1 = new Champion("1 ONEA");
			Champion c2 = new Champion("1 ONEB");
			Champion c3 = new Champion("1 ONEC");

			Champion c4 = new Champion("2 DEUA");
			Champion c5 = new Champion("2 DEUB");
			Champion c6 = new Champion("2 DEUC");

			Champion c7 = new Champion("3Spartacus");
			Champion c8 = new Champion("3Gladiator");
			Champion c9 = new Champion("3Hercule");

			Champion c10 = new Champion("4Spartacus");
			Champion c11 = new Champion("4Gladiator");
			Champion c12 = new Champion("4Hercule");



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
			Equipment trident = new Trident();
			Equipment epee = new Sword();
			Equipment lance = new Spear();
			Equipment grandbouc = new RectangularShield();
			Equipment ptitbouc = new SmallRoundedShield();

			c1.addItem(lance);
			c1.addItem(casque);

			c2.addItem(dague);
			c2.addItem(grandbouc);


			c3.addItem(epee);
			c3.addItem(ptitbouc);

			c4.addItem(lance);
			c4.addItem(casque);

			c5.addItem(epee);
			c5.addItem(ptitbouc);

			c6.addItem(dague);
			c6.addItem(dague);c6.addItem(dague);c6.addItem(dague);c6.addItem(dague);

			/*c7.addItem(i1);
			c7.addItem(i1);
			c7.addItem(i1);
			c7.addItem(i1);

			c8.addItem(i1);
			c8.addItem(i5);

			c9.addItem(i1);
			c9.addItem(i5);

			c10.addItem(i1);
			c10.addItem(i5);

			c11.addItem(i1);
			c11.addItem(i5);

			c12.addItem(i1);
			c12.addItem(i5);

*/

			Game newGame = new Game(p1, p2);
			newGame.start();
		}
	}
}
