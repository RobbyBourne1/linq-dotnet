using System;
using System.Collections.Generic;
using System.Linq;

namespace Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    public static int sumOfEarthShips (List<Spaceship> ships) {
        
        var earthShip = ships.Where(w => w.HasWarpDrive).Select(s => s.Name).Count();
        Console.WriteLine(new Spaceship());
        Console.WriteLine(earthShip);
        
        return -1;
    }

    public static void sendShipsToFightMonsters (List<Spaceship> ships) {

    }

    public static Spaceship findMostGunsWithSize(List<Spaceship> ships, int size) {
        return null;
    }

    public static IEnumerable<Spaceship> ExplorationFleet(List<Spaceship> ships) {
        return null;
    }
    
    }
}

