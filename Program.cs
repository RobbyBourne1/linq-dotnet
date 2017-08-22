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

          Console.WriteLine($"{sumOfEarthShips(spaceships)} Are going to be Staying Home");
        }

        public static int sumOfEarthShips(List<Spaceship> ships)
        {

            var earthShip = ships.Where(w => w.HasWarpDrive == false).Select(s => s.Name).Count();
            return earthShip;
        }

        public static void sendShipsToFightMonsters(List<Spaceship> ships)
        {

        }

        public static Spaceship findMostGunsWithSize(List<Spaceship> ships, int size)
        {
            return null;
        }

        public static IEnumerable<Spaceship> ExplorationFleet(List<Spaceship> ships)
        {
            return null;
        }

    }
}

