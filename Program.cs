using System;
using System.Collections.Generic;
using System.Linq;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
          var spaceships = new List<Spaceship>();
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
          spaceships.Add(new Spaceship());
  
          Console.WriteLine($"{sumOfEarthShips(spaceships)} Are going to be Staying Home");

          sendShipsToFightMonsters(spaceships);
          
          foreach (var item in ExplorationFleet(spaceships))
          {
              Console.WriteLine($"{item.Name}");
          }

          Console.WriteLine($"{findMostGunsWithSize(spaceships, 10).Name} Has the most lasers");


        }

        public static int sumOfEarthShips(List<Spaceship> ships)
        {

            var earthShip = ships.Where(w => w.HasWarpDrive == false).Select(s => s.Name).Count();
            return earthShip;
        }

        public static void sendShipsToFightMonsters(List<Spaceship> ships)
        {
            var fighterShips = ships.Where(w => w.HasWarpDrive == true).ToList();
            foreach (Spaceship ship in fighterShips)
            {
              ship.fightSpaceMonster();
            }
        }

        public static Spaceship findMostGunsWithSize(List<Spaceship> ships, int size)
        {
            var biggestShip = ships.Where(s => s.Size == size).OrderByDescending(l => l.NumLasers).First();
            return biggestShip;
        }

        public static IEnumerable<Spaceship> ExplorationFleet(List<Spaceship> ships)
        {
            var fighterShips = ships.Where(w => w.HasWarpDrive).OrderBy(s => s.NumLasers).Take(5).ToList();
            return fighterShips;
        }

    }
}

