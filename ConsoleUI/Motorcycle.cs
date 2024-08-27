using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public bool HasSideCart { get; set; }
    public string DecalDescription { get; set; }
    public override void DriveAbstract()
    {
        Console.WriteLine($"{DecalDescription}");
        Console.WriteLine("This bike drives cool.");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("This bike can literally drive cooler~");
    }
}