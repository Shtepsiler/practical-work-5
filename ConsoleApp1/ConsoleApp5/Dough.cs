using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Dough
    {
        private double white = 1.5;
        public double White { get; set; }

        private double wholegrain = 1.0;
        public double Wholegrain { get; set; }

        private double crispy = 0.9;
        public double Crispy { get; set; }

        private double chewy = 1.1;
        public double Chewy { get; set; }

        private double homemade = 1.0;
        public double Homemade { get; set; }

        
        public double Calories(double waihgt )
        {
            double calories=0;
            double fl;
            double tec;

            Console.WriteLine("Write flour type");
            string flour = Console.ReadLine();
            if( flour == "white" || flour =="White" )
            {
                fl = White;

            }else
                if (flour == "wholegrain" || flour == "Wholegrain")
            {
                fl = Wholegrain;
            }else
                Console.WriteLine("there is no one");



            Console.WriteLine("Write flour type");
            string techic = Console.ReadLine();
            if (techic == "white" || techic == "White")
            {
                tec = White;

            }
            else
                if (techic == "wholegrain" || techic == "Wholegrain")
            {
                tec = Wholegrain;
            }
            else
                if (techic == "wholegrain" || techic == "Wholegrain")
            {
                tec = Wholegrain;
            }else
            Console.WriteLine("there is no one");



            return calories;
        }


          



    }
}
