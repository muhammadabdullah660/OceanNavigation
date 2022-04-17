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
            Console.WriteLine($"{myAngle.degrees}\u00b0{myAngle.minutes}' {myAngle.direction}");

        }
        public static string displayStringFormat (angle myAngle)
        {
            string x = $"{myAngle.degrees}'{myAngle.minutes}' {myAngle.direction}";
            return x;
        }
    }
}
