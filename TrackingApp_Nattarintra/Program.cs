using System;

namespace TrackingApp_Nattarintra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductContext db = new ProductContext();
            Item items1= new Item("Iphone11", 299, Convert.ToDateTime("2021-05-04"),1);
            db.Items.Add(items1);
            db.SaveChanges();

            Item items2 = new Item("Sumsung note5", 199, Convert.ToDateTime("2008-04-04"), 2);
            db.Items.Add(items2);
            db.SaveChanges();

            Item items3 = new Item("Lenovo", 499, Convert.ToDateTime("2001-08-04"), 2);
            db.Items.Add(items3);
            db.SaveChanges();

            Item items4 = new Item("MacBook Pro", 1099, Convert.ToDateTime("2018-01-03"), 1);
            db.Items.Add(items4);
            db.SaveChanges();

        }
    }
}
