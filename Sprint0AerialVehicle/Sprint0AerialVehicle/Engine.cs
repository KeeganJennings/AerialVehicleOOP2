using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    public class Engine
    {
        public bool isStarted;

        public Engine()
        {
            isStarted = false;
        }

        public void About()
        {

        }

        public void Start()
        {
            isStarted = true;
        }

        public void Stop()
        {
            isStarted = false;
        }
    }
}
