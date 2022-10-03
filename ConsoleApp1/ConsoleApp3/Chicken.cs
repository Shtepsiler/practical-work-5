using System;

namespace ConsoleApp3
{
    internal class Chicken
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }


        public void GetEgg()
        {
            if (age > 0 && age <= 1)
            {
                Console.WriteLine($"Chicken {name} (age {age}) can produce 1 eggs per day.");
            }
            else
            if(age > 1 && age <= 10)
            {
                Console.WriteLine($"Chicken {name} (age {age}) can produce 2 eggs per day.");
            }
            else
            if(age < 10 && age <= 15)
            {
                Console.WriteLine($"Chicken {name} (age {age}) can produce 1 eggs per day.");
            }


        }

        public bool IsPossible()
        {
            if (name.Length>0&&name!=" ") {
                if (age > 0 && age < 15)
                    return true;
                else {
                    Console.WriteLine($"Age should be between 0 and 15.");
                    return false; }

            }

            else
            {
                Console.WriteLine($"name cannot be null, empty or whitespace");
                return false;
            }


        }

    }
}
