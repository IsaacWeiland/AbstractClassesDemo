using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public string InteriorDescription { get; set; }
    public bool HasTrunk { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine(InteriorDescription);
        Console.WriteLine("This car drives smooth.");
    }
}