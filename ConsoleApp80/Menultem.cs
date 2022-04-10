using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp80
{
    internal class Menultem
    {
        public int No { get; set; }
        private static int _no;
        public Menultem()
        {
            _no++;
            No = _no;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<CategoryEnum> Category { get; set; }
       
    }
}
