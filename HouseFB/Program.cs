using HouseFB;


House house = new HouseBuilder()
    .Adress("Kungsholmen 15A")
    .NumberOfRooms(5)
    .NumberOfWindows(25)
    .NumberOfParkingSpots(2)
    .HasSvimmingPool()
    .Build();

Console.WriteLine(house);