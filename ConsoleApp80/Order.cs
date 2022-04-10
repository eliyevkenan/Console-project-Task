using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp80
{
    public class Order
    {
        public int No = 1;
        private static int _no;
        public Order()
        {
            _no++;
            No = _no;

        }
        public string OrderLtems { get; set; }
        public double TotalAmount { get; set; }
        public int Date { get; set; }   
    }
}
