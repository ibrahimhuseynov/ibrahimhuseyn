using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {

        public int No;
        public string Name;
        public double Prince;
        public int Count;
        public Product(int no, string name, double prince)
        {
            this.No = no;
            this.Name = name;
            this.Prince = prince;

        }
    }
}
