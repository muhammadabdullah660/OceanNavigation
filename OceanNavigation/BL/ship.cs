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
        static List<ship> shipList = new List<ship>();

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
        public static void addShipIntoList (ship newShip)
        {
            shipList.Add(newShip);
        }
        public static ship findShip (string serialNum)
        {
            foreach (ship item in shipList)
            {
                if (serialNum == item.shipName)
                {
                    return item;
                }
            }
            return null;
        }
        public static string findShipName (string latitude , string longitude)
        {
            foreach (ship item in shipList)
            {
                if (item.isyes(latitude , longitude))
                {
                    return item.shipName;

                }
            }
            return null;
        }
    }
}
