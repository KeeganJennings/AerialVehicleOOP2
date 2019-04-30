using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    public class Helicopter : AerialVehicle
    {
        public Helicopter()
        {
            MaxAltitude = 8000;
            engine = new Engine();
        }
    }
}
