using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Box box1 = new Box();
            Console.WriteLine("Write height");
            box1.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("Write width");
            box1.Width = double.Parse(Console.ReadLine());
            Console.WriteLine("Write length");
            box1.Length = double.Parse(Console.ReadLine());

            if (box1.IsPossible())
            {
                Console.WriteLine($"Surface Area - {box1.SurfaceArea()}");
                Console.WriteLine($"Lateral Surface Area - {box1.LateralSurfaceArea()}");
                Console.WriteLine($"Volume - {box1.Volume()}");
            }
            else
            {
                Console.WriteLine("Value cannot be calculated");
            }

        }
    }
}
