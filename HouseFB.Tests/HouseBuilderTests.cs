using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseFB.Tests
{
    [TestFixture]
    public class HouseBuilderTests
    {

        [TestCase(5)]
        public void NumberOfRooms_Get_Should_Return_5_Rooms(int rooms)
        {
            House sut = new HouseBuilder().NumberOfRooms(rooms).Build();
            Assert.AreEqual(5, sut.NoOfRooms);
        }


        [TestCase(25)]
        public void NumberOfWindows_Get_Should_Return_25_Windows(int windows)
        {
            House sut = new HouseBuilder().NumberOfWindows(windows).Build();
            Assert.AreEqual(25, sut.NoOfWindows);
        }

        [TestCase(2)]
        public void NumberOfParkingSpots_Get_Should_Return_2_ParkingSpots(int parkingspots)
        {
            House sut = new HouseBuilder().NumberOfParkingSpots(parkingspots).Build();
            Assert.AreEqual(2, sut.ParkingSpotsInGarage);   
        }

        [TestCase(0)]
        public void NumberOfRooms_Testing_Expected_Exeption_When_Room_Is_0(int rooms)
        {
            Assert.That(() => new HouseBuilder().NumberOfRooms(rooms),
            Throws.TypeOf<ArgumentOutOfRangeException>()
            .With.Message.EqualTo("Specified argument was out of the range of valid values. (Parameter 'A house cannot have negative number of rooms')"));

        }

    }
}
