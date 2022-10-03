using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Person
    {
        private string name;
        private int money;
       public List<Product> bye = new List<Product>();
        public string Name { get { return name; } set { name = value; } }

        public int Money { get { return money; } set { money = value; } }

    }
}
