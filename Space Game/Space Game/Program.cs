using System;

namespace Space_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Story.Introduction();
            string userName = Story.UserCharacter();
            Console.Clear();
            Story.UserGreeting(userName);
            Story.ShipMessage();
            Console.Clear();

            Planet.TravelMessage(userName, planet);
        }
    }
}
