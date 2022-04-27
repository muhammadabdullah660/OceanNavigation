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
            string path = "ship.txt";
            shipDL.loadFromFile(path);
            int op = 0;
            while (op < 5)
            {
                MenuUI.clearScreen();
                op = MenuUI.mainMenu();
                if (op == 1)
                {
                    MenuUI.clearScreen();
                    ship newShip = shipUI.addShip();
                    shipDL.addShipIntoList(newShip);
                    shipDL.storeIntoFile(path , newShip);

                }
                else if (op == 2)
                {
                    MenuUI.clearScreen();
                    shipUI.viewShipPosition();
                }
                else if (op == 3)
                {
                    MenuUI.clearScreen();
                    shipUI.viewShipSerialNum();

                }
                else if (op == 4)
                {
                    MenuUI.clearScreen();
                    shipUI.changePosition();

                }

            }
        }

    }
}
