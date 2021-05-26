using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackingApp_Nattarintra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Nattarintra AB Product!");
            ProductContext db = new ProductContext();

            Location shopLocations = new Location("Denmark");
            db.Locations.Add(shopLocations);
            db.SaveChanges();

            List<Item> items = new List<Item>()
            {
                 new Item("Iphone11", 299, Convert.ToDateTime("2020-04-04"), 1),
                 new Item("Iphone12", 399, Convert.ToDateTime("2021-05-04"), 1),
                 new Item("Iphone9", 199, Convert.ToDateTime("2018-03-04"), 1),
            };

            List<Device> devices = new List<Device>()
            {
                new Device("Mobile Phones"),
                new Device("Desktop"),
            };

            shopLocations.Items = new List<Item>();
            shopLocations.Items.AddRange(items);
            shopLocations.Devices = new List<Device>();
            shopLocations.Devices.AddRange(devices);
            db.Locations.Add(shopLocations);
            db.SaveChanges();


            Console.ReadLine();

            /* List<Item> items = db.Items.ToList();

             // CRUD
             // CREATE
             Item itemCreate = new Item("Iphone11", 299, Convert.ToDateTime("2021-05-04"), 1);
             db.Items.Add(itemCreate);
             db.SaveChanges();

             //READ
             Item itemRead = db.Items.FirstOrDefault();

             // UPDATE 
             Item itemUpdate = db.Items.Where(item => item.Price.Equals(299)).FirstOrDefault();
             itemUpdate.ItemName = "Nokia";
             itemUpdate.Price = 150;
             db.Items.Update(itemUpdate);
             db.SaveChanges();*/

            // DELETE
            /*Item itemDelete = db.Items.Where(item => item.Id == 1).FirstOrDefault();
            db.Items.Remove(itemDelete);
            db.SaveChanges();*/


            // Console.ReadLine();



            /*
            Item items1= new Item("Iphone11", 299, Convert.ToDateTime("2021-05-04"),1);
            //Item items1= new Item("Iphone11", 299,1);
            db.Items.Add(items1);
            db.SaveChanges();

            Item items2 = new Item("Sumsung note5", 199, Convert.ToDateTime("2008-04-04"), 2);
            //Item items2 = new Item("Sumsung note5", 199, 2);
            db.Items.Add(items2);
            db.SaveChanges();

            Item items3 = new Item("Lenovo", 499, Convert.ToDateTime("2001-08-04"), 2);
            //Item items3 = new Item("Lenovo", 499, 2);
            db.Items.Add(items3);
            db.SaveChanges();

            Item items4 = new Item("MacBook Pro", 1099, Convert.ToDateTime("2018-01-03"), 1);
            //Item items4 = new Item("MacBook Pro", 1099, 1);
            db.Items.Add(items4);
            db.SaveChanges();
            */
        }
    }
}
