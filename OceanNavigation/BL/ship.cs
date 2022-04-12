using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    class ship
    {
        public string shipName;
        public angle longitude;
        public angle latitude;
        public static List<ship> shipList = new List<ship>();

        public ship (string shipName , angle longitude , angle latitude)
        {
            this.shipName = shipName;
            this.longitude = longitude;
            this.latitude = latitude;
        }
        public void printLocation ()
        {
            Console.WriteLine($"Ship is at ");
            longitude.displayPosition();
            latitude.displayPosition();
        }
        public bool isyes (string latitude , string longitude)
        {
            string lon = this.longitude.displayStringFormat();
            string lat = this.latitude.displayStringFormat();
            if (latitude == lat && longitude == lon)
            {
                return true;
            }
            return false;
        }
        public void printName ()
        {
            Console.WriteLine(shipName);
        }
    }
}
