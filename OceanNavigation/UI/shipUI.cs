using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
namespace OceanNavigation.UI
{
    class shipUI
    {
        public static ship addShip ()
        {
            Console.WriteLine("Enter Ship Serial Number");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude:");
            Console.WriteLine("Enter Latitude's Degree:");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Minutes:");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Direction:");
            char direction = char.Parse(Console.ReadLine());
            angle latitude = new angle(degree , minutes , direction);
            Console.WriteLine("Enter Ship Longitude:");
            Console.WriteLine("Enter Longitude's Degree:");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Minutes:");
            minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Direction:");
            direction = char.Parse(Console.ReadLine());
            angle longitude = new angle(degree , minutes , direction);
            ship newShip = new ship(name , longitude , latitude);
            return newShip;

        }
        public static void printLocation (angle longitude , angle latitude)
        {
            Console.WriteLine($"Ship is at ");
            angleUI.displayPosition(longitude);
            angleUI.displayPosition(latitude);
        }
        public static void viewShipPosition ()
        {
            Console.WriteLine("Enter Ship Serial Number To Find Its Position:");
            string serialNum = Console.ReadLine();
            ship req = shipDL.findShip(serialNum);
            if (req != null)
            {
                shipUI.printLocation(req.longitude , req.latitude);

            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
        public static void changePosition ()
        {
            Console.WriteLine("Enter Ship Serial Number To Change Its Position:");
            string serialNum = Console.ReadLine();
            ship req = shipDL.findShip(serialNum);
            if (req != null)
            {


                Console.WriteLine("Enter Latitude's Degree:");
                int degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Latitude's Minutes:");
                float minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Latitude's Direction:");
                char direction = char.Parse(Console.ReadLine());
                req.latitude.changePosition(degree , minutes , direction);
                Console.WriteLine("Enter Ship Longitude:");
                Console.WriteLine("Enter Longitude's Degree:");
                degree = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Longitude's Minutes:");
                minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter Longitude's Direction:");
                direction = char.Parse(Console.ReadLine());
                req.longitude.changePosition(degree , minutes , direction);
            }
            else
            {
                Console.WriteLine("Not Exist");
            }

        }
        public static void viewShipSerialNum ()
        {
            Console.WriteLine("Enter Ship Latitude:");
            string latitude = Console.ReadLine();
            Console.WriteLine("Enter Ship Longitude:");
            string longitude = Console.ReadLine();
            string shipName = shipDL.findShipName(latitude , longitude);
            if (shipName != null)
            {
                Console.WriteLine(shipName);

            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
    }
}
