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
        private string shipName;
        private angle longitude;
        private angle latitude;

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
        public string getShipName ()
        {
            return shipName;
        }
        public angle getShipLat ()
        {
            return latitude;
        }
        public angle getShipLon ()
        {
            return longitude;
        }
        public void setShipName (string shipName)
        {
            this.shipName = shipName;
        }
        public void setShipLat (angle latitude)
        {
            this.latitude = latitude;
        }
        public void setShipLon (angle longitude)
        {
            this.longitude = longitude;
        }
       
    }
}
