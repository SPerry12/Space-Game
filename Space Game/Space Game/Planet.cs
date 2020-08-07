using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Planet
    {
        // Earth starting position 0,0
        public static string Earth(string greeting)
        {
            Console.WriteLine(greeting);
            int x = 0;
            int y = 0;
            string planet = "Earth";
            return planet;


        }

        // Alpha Proxima 1 position 4.7,0
        public static string AlphaPromixa(string greeting)
        {
            Console.WriteLine(greeting);
            double x = 4.7;
            int y = 0;
            string planet = "Alpha Promixa 1";
            return planet;
        }

        // Venus Prime position 5,2
        public static string VenusPrime(string greeting)
        {
            Console.WriteLine(greeting);
            int x = 5;
            int y = 2;
            string planet = "Venus Prime";
            return planet;
        }

        // Jupiter X position 14,3
        public static string JupiterX(string greeting)
        {
            Console.WriteLine(greeting);
            int x = 14;
            int y = 3;
            string planet = "Jupiter X";
            return planet;
        }

        // New Mars position 18,13
        public static string NewMars(string greeting)
        {
            Console.WriteLine(greeting);
            int x = 18;
            int y = 13;
            string planet = "New Mars";
            return planet;
        }


        public static void TravelMessage(string userName, string planet)
        {
            Console.WriteLine("Select a planet to travel to:");
            Console.WriteLine("");
            Console.WriteLine("1. Earth");  // TODO May need to go back and use string interpolation here
            Console.WriteLine("2. Alpha Proxima 1");
            Console.WriteLine("3. Venus Prime");
            Console.WriteLine("4. Jupiter X");
            Console.WriteLine("5. New Mars");

            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Planet.ArrivalMessage(userName, planet);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Planet.ArrivalMessage(userName, planet);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Planet.ArrivalMessage(userName, planet);
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Planet.ArrivalMessage(userName, planet);
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Planet.ArrivalMessage(userName, planet);
                    break;
            }

        }

        public static void ArrivalMessage(string userName, string planet)
        {

            string greeting = $"Welcome to {planet}, {userName}!";
            Console.WriteLine(greeting);
            Console.WriteLine("");
            Console.WriteLine("Select the items you wish to purchase:");
            Console.WriteLine("1. Food \n2. Weapons/Ammo \n3. Luxury Goods \n4. Minerals/Ore ");

        }
    }
}
