using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();   

            string[] subs;
            Console.WriteLine( $"write people" );
               string first = Console.ReadLine();


                subs = first.Split(';');
                
                foreach (var sub in subs)
                {  
                    Person person = new Person();
                    string[] second = sub.Split('=');

                    person.Name = second[0]; 
                if(int.Parse(second[1]) >= 0)
                    person.Money = int.Parse(second[1]);
                else
                {
                    Console.WriteLine($"Money cannot be negative");
                }
                    people.Add(person);

                }

            Console.WriteLine($"write products");

            string[] subs1;
              
                    string first1 = Console.ReadLine();


                    subs1 = first1.Split(';');

                    foreach (var sub in subs1)
                    {
                Product product = new Product();
                string[] second = sub.Split('=');

                        product.Name = second[0];
                        product.Cost = int.Parse(second[1]);

                        products.Add(product);

                    }
                   string[] aray;
               
            
            
            
            
            do{
                Console.WriteLine($"write comand");
               string  comand = Console.ReadLine();

               aray  = comand.Split(' ');
                foreach(var pers in people)
                {

                    if(pers.Name == aray[0])
                    {
                        Product prod = new Product();
                        foreach(var product in products)
                        {
                            if(product.Name == aray[1])
                            {
                                prod=product;

                            }
                        }
                        pers.Money = pers.Money - prod.Cost;
                        if (pers.Money >= 0)
                        {
                            Console.WriteLine($"{pers.Name} bought {prod.Name}");

                            pers.bye.Add(prod);
                        }
                        else
                        {
                            Console.WriteLine($"{pers.Name} can't afford {prod.Name}");

                        }

                    }

                }




                } while (aray[0]!="END");


            foreach (var pers in people)
            {
           if(pers.bye.Count ==0)
                    Console.WriteLine($"{pers.Name} – Nothing bought");
            }

         
            foreach (var pers in people)
            {
                if (pers.bye.Count > 0)
                {
                    Console.Write($"{pers.Name} - ");
                    foreach (var product in pers.bye)
                    {
                        Console.Write($"{product.Name}, ");
                    }
                    Console.WriteLine(); 
                }

            }



        }
    }
}
