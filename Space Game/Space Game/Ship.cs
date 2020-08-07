using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Ship
    {
        public static void WarpSpeed() //This method gives the days it takes to travel 
        {
            Console.WriteLine("Please select Warp Speed (1-9.5)"); // Right now the user can enter anything...needs a loop to repeat until user gives correct warp speed (1-9.5)
            int warp = int.Parse(Console.ReadLine());

            double speedOfShip = (Math.Pow(warp, 10 / 3) + Math.Pow((10 - warp), -11 / 3));

            double travelTime = 10 * 365.25 / speedOfShip; //TODO find a way to replace 10 with the variable for light years (determined from the Pythagorean Theorem)

            Console.WriteLine($"It will take {travelTime:N2}"); //TODO travelTime will be added to age each time the player travels between planets

        }

        /* public double DistanceCalculator()
         {
             // Takes x,y coordinates of planets and puts them in the pythagorean theorem

             double distanceBetweenPlanets = Math.Sqrt(planetCoordX * planetCoordX + planetCoordY * planetCoordY);

             return distanceBetweenPlanets;

         } */
    }
}
