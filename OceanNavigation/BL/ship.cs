using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.UI;
namespace OceanNavigation.BL
{
    class ship
    {
        public string shipName;
        public angle longitude;
        public angle latitude;

        public ship (string shipName , angle longitude , angle latitude)
        {
            this.shipName = shipName;
            this.longitude = longitude;
            this.latitude = latitude;
        }

        public bool isyes (string latitude , string longitude)
        {
            string lon = angleUI.displayStringFormat(this.longitude);
            string lat = angleUI.displayStringFormat(this.latitude);
            if (latitude == lat && longitude == lon)
            {
                return true;
            }
            return false;
        }
        /*public void printName ()
        {
            Console.WriteLine(shipName);
        }*/
    }
}
