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
            set { height = value; }
        }
        public double Width
        {
            get { return width; }   // get method
            set { width = value; }
        }
        public double Length
        {
            get { return length; }   // get method
            set { length = value; }
        }


        public double SurfaceArea()
        {
            return ((height * width*2)+(2*width*length)+(2*length*height));
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
