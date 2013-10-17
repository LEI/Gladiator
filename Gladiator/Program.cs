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

			Game newGame = new Game(p1,p2);
			
			Team t1 = new Team("A", "lol");
			Team t2 = new Team("B", "lol");
			Team t3 = new Team("C", "lol");
			Team t4 = new Team("D", "lol");
			
			p1.addTeam(t1);
			p1.addTeam(t3);
			
			p2.addTeam(t2);
			p2.addTeam(t4);

			// Affichage du nom des équipes du joueur 1
			/*foreach (Team t in p1.TeamList) {
				Console.WriteLine(t.Name);
			}*/
			
			// Affichage du nombre d'équipes du joueur 1
			//Console.WriteLine(p1.TeamList.Count);

			Champion c1 = new Champion("Spartacus");
			Champion c2 = new Champion("Gladiator");
			Champion c3 = new Champion("Hercule");
			
			t1.addChampion(c1);
			t1.addChampion(c2);
			t1.addChampion(c3);

			t1.viewOrder ();	
			
			// Affichage du nom des équipes du joueur 1
			/*foreach (Champion c in t1.ChampList) {
				Console.WriteLine(c.Name);
			}*/
			t1.orderChampion (0, 1);
			t1.viewOrder ();	

			t1.orderChampion (0, 2);
			t1.viewOrder ();	
			Equipment i1 = new Dagger();
			Equipment i2 = new Helmet();
			Equipment i3 = new Net();
			Equipment i4 = new Trident ();
			Equipment i5 = new Sword ();

			c1.addItem(i1);
			c1.addItem(i2);
			c1.addItem(i3);
			c1.addItem (i4);

			c1.deleteItem (i3);
			c1.addItem (i5);
			// Affichage des items du champion 1
			foreach (Equipment e in c1.ItemList) {
				Console.WriteLine(e.Name + " : " + e.Weight + " pts");
				if (e is IOffense) {
					Console.WriteLine(e.Offense*100 + "% chance de toucher");
				}
				if (e is IDefense) {
					Console.WriteLine(e.Defense*100 + "% chance de parer");
				}
			}
			
			Console.WriteLine(newGame.start());
		}
	}
}
