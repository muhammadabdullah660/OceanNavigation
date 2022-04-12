using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;

namespace OceanNavigation
{
    class Program
    {
        static void Main ()
        {
            int op = 0;
            while (op < 8)
            {
                clearScreen();
                op = mainMenu();
                if (op == 1)
                {
                    clearScreen();

                    ship.addShipIntoList(addShip());

                }
                else if (op == 2)
                {
                    clearScreen();
                    viewShipPosition();
                }
                else if (op == 3)
                {
                    clearScreen();
                    viewShipSerialNum();

                }
                else if (op == 4)
                {
                    clearScreen();
                    changePosition();

                }

            }
        }
        static int mainMenu ()
        {
            int op;
            Console.WriteLine("******************************");
            Console.WriteLine("       OCEAN NAVIGATION       ");
            Console.WriteLine("******************************");
            Console.WriteLine("1- Add Ship");
            Console.WriteLine("2- View Ship Position");
            Console.WriteLine("3- View Ship Serial Number");
            Console.WriteLine("4- Change Ship Position");
            Console.WriteLine("5- Exit");
            op = int.Parse(Console.ReadLine());
            return op;

        }
        static void clearScreen ()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static ship addShip ()
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
        static void viewShipPosition ()
        {
            Console.WriteLine("Enter Ship Serial Number To Find Its Position:");
            string serialNum = Console.ReadLine();
            ship req = ship.findShip(serialNum);
            if (req != null)
            {
                req.printLocation();

            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
        static void changePosition ()
        {
            Console.WriteLine("Enter Ship Serial Number To Change Its Position:");
            string serialNum = Console.ReadLine();
            ship req = ship.findShip(serialNum);
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

        static void viewShipSerialNum ()
        {
            Console.WriteLine("Enter Ship Latitude:");
            string latitude = Console.ReadLine();
            Console.WriteLine("Enter Ship Longitude:");
            string longitude = Console.ReadLine();
            string shipName = ship.findShipName(latitude , longitude);
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
