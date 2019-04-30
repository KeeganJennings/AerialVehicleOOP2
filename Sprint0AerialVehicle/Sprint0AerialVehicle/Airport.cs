using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint0AerialVehicle
{
    public class Airport
    {
        public int maxVehicles = 10;
        public List<AerialVehicle> Vehicles = new List<AerialVehicle>();

        public string AirportCode { get; set; }

        public Airport(string Code)
        {
            AirportCode = Code;
        }

        public Airport(string Code, int MaxVehicles)
        {
            AirportCode = Code;
            maxVehicles = MaxVehicles;
        }

        public string AllTakeOff()
        {
            for(int i = 0; i < Vehicles.Count; i++)
            {
                Vehicles[i].StartEngine();
                Vehicles[i].IsFlying = true;
                Vehicles[i].FlyUp();
            }
            Vehicles.Clear();
            return "All took off";
        }

        public string Land(AerialVehicle a)
        {
            if(Vehicles.Count + 1 <= maxVehicles)
            {
                a.FlyDown(a.CurrentAltitude);
                a.IsFlying = false;

                Vehicles.Add(a);
            }

            return $"Landed {a.GetType()} ";
        }

        public string Land(List<AerialVehicle> landing)
        {
            string landedVehicles = "";
            if(Vehicles.Count + landing.Count <= maxVehicles)
            {
                foreach (AerialVehicle aerialVehicle in landing)
                {
                    aerialVehicle.FlyDown(aerialVehicle.CurrentAltitude);
                    aerialVehicle.IsFlying = false;
                    Vehicles.Add(aerialVehicle);
                    landedVehicles += aerialVehicle.GetType() + " ";
                }
            }

            return landedVehicles;
        }

        public string TakeOff(AerialVehicle a)
        {
            a.StartEngine();
            a.IsFlying = true;
            a.FlyUp();

            Vehicles.Remove(a);
            return $"{a.GetType()} has taken off!";
        }
    }
}
