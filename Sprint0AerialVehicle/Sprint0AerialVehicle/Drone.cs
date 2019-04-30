using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    public class Drone : AerialVehicle
    {
        public Drone()
        {
            MaxAltitude = 500;
            engine = new Engine();
        }

        public override void FlyUp()
        {
            if (CurrentAltitude + 100 < MaxAltitude)
            {
                this.CurrentAltitude += 100;
            }
        }

        public override void FlyDown()
        {
            if (CurrentAltitude - 100 >= 0)
            {
                CurrentAltitude -= 100;
            }
        }
    }
}
