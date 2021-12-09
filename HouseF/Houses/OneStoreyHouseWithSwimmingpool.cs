using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class OneStoreyHouseWithSwimmingpool : House
    {
        public OneStoreyHouseWithSwimmingpool()
        {
            StreetAdress = "Drottningsgatan 4C";
            NoOfRooms = 5;
            NoOfWindows = 25;
            ParkingSpotsInGarage = 1;
            HasSwimmingPool = true;
        }
    }
}
