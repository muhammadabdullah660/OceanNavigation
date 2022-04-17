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

        public void changePosition (int degrees , float minutes , char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }
    }
}
