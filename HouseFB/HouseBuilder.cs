using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB
{
    public class HouseBuilder
    {
        private House _house;


        public HouseBuilder()
        {
            _house = new House();   
        }

        public HouseBuilder Adress(string adress)
        {
            _house.StreetAdress = adress;
            return this;
        }

        public HouseBuilder NumberOfRooms(int rooms)
        {
            if(rooms <= 0)
            {
                throw new ArgumentOutOfRangeException("A house cannot have negative number of room");
            }
            _house.NoOfRooms = rooms;
            return this;
        }

        public HouseBuilder NumberOfWindows(int windows)
        {
            if(windows <= 0)
            {
                throw new ArgumentOutOfRangeException("A house must have one or more windows");
            }
            _house.NoOfWindows = windows;
            return this;
        }

        public HouseBuilder NumberOfParkingSpots(int parkingspots)
        {
            _house.ParkingSpotsInGarage = parkingspots;
            return this;
        }


        public House Build()
        {
            return _house;
        }
    }
}
