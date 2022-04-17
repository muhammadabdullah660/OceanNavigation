using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
namespace OceanNavigation.DL
{
    class shipDL
    {
        public static List<ship> shipList = new List<ship>();
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
