using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book:Product
    {
        public string Genre;
        public Book(string genre, int NO, string name, double prince) : base(NO, name, prince)
        {
            this.Genre = genre;
        }
    }
}
