using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.UI
{
    class MenuUI
    {
        public static int mainMenu ()
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
        public static void clearScreen ()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
