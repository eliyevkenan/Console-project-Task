using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp80
{
    public interface IRestaurantManager
    {
        public List<Menultem> Menultems { get; }
        public void AddOrder(string name, double price, int no);
        public void RemoveOrder(string no);

        public int GetOrdersByDatesInvertal(DateTime startDate, DateTime endDate);
        public double GetOrdersByPriceInterval(double minprice,double maxprice);
        public void AddMenuItem(string name, double price, string categor);
        public void RemoveMenuItem(int no);
        public void EditMenuItem(string name,double price);
        

    }
}
