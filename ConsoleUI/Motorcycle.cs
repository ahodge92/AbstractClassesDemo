using System;
namespace ConsoleUI
{
    public class Motorcycle:Vehicle
    {
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motocycle is in drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This Motocycle is in drive virtually");
        }
    }
}
