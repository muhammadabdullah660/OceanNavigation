using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
namespace OceanNavigation.UI
{
    class angleUI
    {
        public static void displayPosition (angle myAngle)
        {
            Console.WriteLine($"{myAngle.getDegrees()}\u00b0{myAngle.getMinutes()}' {myAngle.getDirection()}");

        }
        public static string displayStringFormat (angle myAngle)
        {
            string x = $"{myAngle.getDegrees()}'{myAngle.getMinutes()}' {myAngle.getDirection()}";
            return x;
        }
    }
}
