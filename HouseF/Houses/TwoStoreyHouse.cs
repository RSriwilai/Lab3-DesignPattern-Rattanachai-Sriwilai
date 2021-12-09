using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class TwoStoreyHouse : House
    {
        public TwoStoreyHouse()
        {
            StreetAdress = "Taljvägen 1A";
            NoOfRooms = 5;
            NoOfWindows = 20;
            ParkingSpotsInGarage = 1;
        }
    }
}
