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
			
			p1.AddTeam(t1);
			p1.AddTeam(t3);
			
			p2.AddTeam(t2);
			p2.AddTeam(t4);


			//Equipment d = new Dagger();
			foreach (Team t in p1.TeamList) {
				
				Console.WriteLine(t.Name);

			}



			
			Console.WriteLine(newGame.start());
		}
	}
}
