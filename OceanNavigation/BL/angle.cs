using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    class angle
    {
        public int degrees;
        public float minutes;
        public char direction;
        public angle (int degrees , float minutes , char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }
        public void displayPosition ()
        {
            Console.WriteLine($"{degrees}\u00b0{minutes}' {direction}");

        }
        public string displayStringFormat ()
        {
            string x = $"{degrees}'{minutes}' {direction}";
            return x;
        }
        public void changePosition (int degrees , float minutes , char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }
    }
}
