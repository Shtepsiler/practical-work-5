using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Chicken chicken = new Chicken();
            Console.WriteLine("Write name of chicken");
            chicken.Name = Console.ReadLine();
            Console.WriteLine("Write age of chicken");
            chicken.Age = int.Parse(Console.ReadLine());

            if (chicken.IsPossible())
            {
                chicken.GetEgg();
            }
           


        }
    }
}
