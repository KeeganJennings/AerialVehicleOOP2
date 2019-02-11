using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    public class ToyPlane : Airplane
    {
        public bool isWoundUp;

        public ToyPlane()
        {
            MaxAltitude = 50;
            isWoundUp = false;
        }

        public string About()
        {
            string aboutString = "";

            aboutString = "This " + this + " has a max altitude of " + MaxAltitude + " ft. \nIt's current altitude is " + CurrentAltitude + " ft. \n";

            return aboutString;
        }

        public string getWindUpString()
        {
            if(isWoundUp)
            {
                return this + " is wound up";
            }
            else
            {
                return this + " is not wound up";
            }
        }

        public void StartEngine()
        {
            if(isWoundUp)
            {
                StartEngine();
            }
        }

        public string TakeOff()
        {
            string returnTakeOff = "";
            if (isWoundUp != true)
            {
                returnTakeOff = this + " cannot take off because it's engine is not started";
            }

            return returnTakeOff;
        }

        public void UnWind()
        {
            isWoundUp = false;
            getWindUpString();
        }

        public void WindUp()
        {
            isWoundUp = true;
            getWindUpString();
        }
    }
}
