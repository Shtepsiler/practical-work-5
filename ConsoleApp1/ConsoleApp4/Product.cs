using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Product
    {
        private string name;
        private int cost;

        public string Name { get { return name; } set { name = value; } }

        public int Cost { get { return cost; } set { cost = value; } }   
    }
}
