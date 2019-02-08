using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    abstract class AerialVehicle
    {
        protected int CurrentAltitude { get; set; }
        protected int MaxAltitude { get; set; }
        Engine engine { get; set; }
        protected bool IsFlying { get; set; }

        public string About()
        {
            string aboutString = "";

            aboutString = "This " + this + " has a max altitude of " + MaxAltitude + " ft. \nIt's current altitude is " + CurrentAltitude + " ft. \n";

            if(!engine.isStarted)
            {
                aboutString += this.engine + " is not started";
            }
            else
            {
                aboutString += this.engine + " is started";
            }

            return aboutString;
        }

        public string GetEngineStartedString()
        {
            if(engine.isStarted)
            {
                return this + " is flying";
            }
            else
            {
                return this + " is no longer flying";
            }
        }

        public string TakeOff()
        {
            string returnTakeOff = "";
            if(engine.isStarted != true)
            {
                returnTakeOff = this + " cannot take off because it's engine is not started";   
            }

            return returnTakeOff;
        }

        public void FlyDown()
        {
            if(CurrentAltitude - 1000 > 0)
            {
                CurrentAltitude -= 1000;
            }
        }

        public void FlyDown(int HowManyFeet)
        {
            if(CurrentAltitude - HowManyFeet < 0)
            {

            }
            else
            {
                CurrentAltitude -= HowManyFeet;
            }
        }

        public void FlyUp()
        {
            if(CurrentAltitude + 1000 < 41000)
            {
                this.CurrentAltitude += 1000;
            }
        }

        public void FlyUp(int HowManyFeet)
        {
            if(CurrentAltitude + HowManyFeet > 41000)
            {

            }
            else
            {
                CurrentAltitude += HowManyFeet;
            }
        }

        public void StartEngine()
        {
            engine.Start();
            GetEngineStartedString();
        }

        public void StopEngine()
        {
            engine.Stop();
            GetEngineStartedString();
        }


        public AerialVehicle()
        {

        }
    }
}
