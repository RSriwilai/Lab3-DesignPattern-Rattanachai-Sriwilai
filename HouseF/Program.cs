using HouseF;



HouseFactory houseFactory = new HouseFactory();

House houseNr1 = houseFactory.CreateHouse("onestoreyhouse");
House houseNr2 = houseFactory.CreateHouse("onestoreyhousewithswimmingpool");
House houseNr3 = houseFactory.CreateHouse("twostoreyhouse");

Console.WriteLine(houseNr1);
Console.WriteLine(houseNr2);
Console.WriteLine(houseNr3);