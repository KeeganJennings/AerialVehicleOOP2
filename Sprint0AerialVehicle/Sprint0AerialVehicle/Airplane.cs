﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    public class Airplane : AerialVehicle
    {
       
        public Airplane()
        {
            MaxAltitude = 41000;
            engine = new Engine();
        }
    }
}
