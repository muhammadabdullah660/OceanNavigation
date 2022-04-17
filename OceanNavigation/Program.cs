using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation
{
    class Program
    {
        static void Main ()
        {
            int op = 0;
            while (op < 5)
            {
                clearScreen();
                op = mainMenu();
                if (op == 1)
                {
                    clearScreen();

                    shipDL.addShipIntoList(shipUI.addShip());

                }
                else if (op == 2)
                {
                    clearScreen();
                    shipUI.viewShipPosition();
                }
                else if (op == 3)
                {
                    clearScreen();
                    shipUI.viewShipSerialNum();

                }
                else if (op == 4)
                {
                    clearScreen();
                    shipUI.changePosition();

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
    }
}
