using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ConsoleUI;

public abstract class Vehicle
{
    public static List<Vehicle> Vehicles = new List<Vehicle>();
    public string Year { get; set; } = "2001";
    public string Make { get; set; } = "Honda";
    public string Model { get; set; } = "Odyssey";
    public abstract void DriveAbstract();

    public virtual void DriveVirtual()
    {
        Console.WriteLine("This car can virtually drive already!");
    }
}