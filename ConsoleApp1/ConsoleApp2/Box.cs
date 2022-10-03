using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Box
    {
        private double height;
        private double width;
        private double length;

        public double Height
        {
            get { return height; }   // get method
            set { if (value > 0) height = value; else { Console.WriteLine("vale is impossible"); } }
        }
        public double Width
        {
            get { return width; }   // get method
            set { if (value > 0) width = value; else { Console.WriteLine("vale is impossible"); } }
        }
        public double Length
        {
            get { return length; }   // get method
            set {
                if(value > 0)
                length = value;
                else { Console.WriteLine("vale is impossible"); }
            }
        }



        public bool IsPossible()
        {
            if(Height>0 && Width>0 && Length>0)
                return true;
            else{
                return false;
            }
        }
        public double SurfaceArea()
        {
            return ((height * width * 2) + (2 * width * length) + (2 * length * height));
        }



        public double LateralSurfaceArea()
        {
            return ((height * length * 2) + (length * width * 2));
        }

        public double Volume()
        {
            return (height * width * length);
        }






    }
}
