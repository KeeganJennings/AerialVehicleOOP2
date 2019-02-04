using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    abstract class AerialVehicle
    {
        int CurrentAltitude { get; set; }
        int MaxAltitude { get; set; }
        Engine Engine { get; set; }
        bool IsFlying { get; set; }

        abstract public string About();
        abstract public string GetEngineStartedString();
        abstract public string TakeOff();
        abstract public void FlyDown();
        abstract public void FlyDown(int HowManyFeet);
        abstract public void FlyUp();
        abstract public void FlyUp(int HowManyFeet);
        abstract public void StartEngine();
        abstract public void StopEngine();


        public AerialVehicle()
        {

        }

    }
}
