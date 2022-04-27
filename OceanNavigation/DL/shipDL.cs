using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using System.IO;
namespace OceanNavigation.DL
{
    class shipDL
    {
        private static List<ship> shipList = new List<ship>();
        public static void addShipIntoList (ship newShip)
        {
            shipList.Add(newShip);
        }
        public static ship findShip (string serialNum)
        {
            foreach (ship item in shipList)
            {
                if (serialNum == item.getShipName())
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
                    return item.getShipName();

                }
            }
            return null;
        }
        public static void storeIntoFile (string path , ship newShip)
        {
            StreamWriter f = new StreamWriter(path , true);
            f.WriteLine($"{newShip.getShipName()},{newShip.getShipLon().getDegrees()},{newShip.getShipLon().getMinutes()},{newShip.getShipLon().getDirection()},{newShip.getShipLat().getDegrees()},{newShip.getShipLat().getMinutes()},{newShip.getShipLat().getDirection()}");
            f.Flush();
            f.Close();
        }
        public static void loadFromFile (string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            while ((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string shipName = splittedrecord[0];
                int degrees = int.Parse(splittedrecord[1]);
                float minutes = float.Parse(splittedrecord[2]);
                char direction = char.Parse(splittedrecord[3]);
                angle longitude = new angle(degrees , minutes , direction);
                degrees = int.Parse(splittedrecord[4]);
                minutes = float.Parse(splittedrecord[5]);
                direction = char.Parse(splittedrecord[6]);
                angle latitude = new angle(degrees , minutes , direction);

                ship newShip = new ship(shipName , longitude , latitude);
                shipList.Add(newShip);
            }
            f.Close();
        }
    }
}
