using NorthWind.Data.Contexts;
using NorthWind.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repositories
{
    public  class  Repository(AppDbContext context)
    {
        public  void GetCustomersAndProducts()
        {
            var customers = context.Customers.ToList();
            foreach (var c in customers) {

                if (c.Orders is not null)
                    Console.WriteLine($"Name : {c.ContactName} , Address = {c.Address} , orders Details = ");
                foreach (var order in c.Orders)
                {
                    Console.WriteLine($"==== shiping vai =  {order.ShipVia} ,date =  {order.OrderDate} , id = {order.OrderId}");
                } 
            }
        }

        public void GetProductsBySuppliers(string suplier = "Exotic Liquids")
        {
            var products = context.Products.Where(e => e.Supplier.CompanyName == suplier);
            if (products is null) {
                Console.WriteLine("there is supplier is  not exsist  ");
            }

            foreach (var p in products)
            {
                 Console.WriteLine($"Product name by {suplier} company : {p.ProductName} ");
            }
        }

        public void GetTopFiveCustomersByNumberOforeder() {
            var customers = context.Customers.OrderBy(e=> e.Orders.Count()).Take(5).ToList();

            for (int i = 0;i< 5;i++)
            {
                Console.WriteLine($" {i+1}) Customer name : {customers[i]
                    .ContactName} ");
            }
        }
    }
}
