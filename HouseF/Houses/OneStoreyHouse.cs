using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class OneStoreyHouse : House
    {
        public OneStoreyHouse()
        {
            StreetAdress = "Mästaregatan 2B";
            NoOfRooms = 3;
            NoOfWindows = 20;
            ParkingSpotsInGarage = 1;
        }
    }
}
