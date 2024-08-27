using System;
using System.Collections.Generic;

namespace ConsoleUI;

public class LoopClass
{

    public static void Assignment()
    {
        var chevy = new Car()
        {
            Year = "2014",
            Make = "Chevrolet",
            Model = "Equinox",
            InteriorDescription = "black polyester seats that sit 5",
            HasTrunk = false //i'm going with what my dad always told me, "it's not a trunk its just the back of the car"
        };
        Vehicle.Vehicles.Add(chevy);
        var harley = new Motorcycle()
        {
            Year = "1957",
            Make = "Harley Davidson",
            Model = "Sportster",
            DecalDescription = "really cool flame stickers",
            HasSideCart = false
        };
        Vehicle.Vehicles.Add(harley);
        Vehicle mazda = new Car()
        {
            Year = "2014",
            Make = "Mazda",
            Model = "Mazda 2",
            HasTrunk = false, //read above
            InteriorDescription = "Black nylon seats that sit 2 because the back is filthy"
        };
        Vehicle.Vehicles.Add(mazda);
        Vehicle honda = new Motorcycle()
        {
            Year = "2022",
            Make = "Honda",
            Model = "Gold Wing",
            DecalDescription = "Blue",
            HasSideCart = false
        };
        Vehicle.Vehicles.Add(honda);
        foreach (var vehicle in Vehicle.Vehicles)
        {
            Console.WriteLine($"This is a {vehicle.Year} {vehicle.Model} by {vehicle.Make}.");
            Console.WriteLine("Vehicle description:");
            vehicle.DriveAbstract();
            vehicle.DriveVirtual();
        }
    }
}