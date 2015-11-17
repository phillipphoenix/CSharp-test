using System;
using System.Data.Entity;
using System.Linq;
using Opg2.Entities;

namespace Opg2
{
    class WebShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }

    class TestWebShopContext
    {
        static int Main(string[] args)
        {
            using (var context = new WebShopContext())
            {
                if (!(from o in context.Orders select o).Any())
                {
                    // Product 1
                    var price0 = new Price
                    {
                        Id = 1,
                        FromDate = DateTime.Now,
                        Value = 100,
                        Currency = "DKK",
                        OnSale = false
                    };
                    var product0 = new Product
                    {
                        ProductNb = "p1",
                        Name = "Fancy Product",
                        Description = "This is a very fancy product."
                    };
                    product0.Prices.Add(price0);
                    // Product 2
                    var price1 = new Price
                    {
                        Id = 2,
                        FromDate = DateTime.Parse("2015-10-12"),
                        Value = 499,
                        Currency = "DKK",
                        OnSale = false
                    };
                    var price2 = new Price
                    {
                        Id = 3,
                        FromDate = DateTime.Now,
                        Value = 399,
                        Currency = "DKK",
                        OnSale = true
                    };
                    var product1 = new Product
                    {
                        ProductNb = "p2",
                        Name = "Product on sale",
                        Description = "This product is currently on sale."
                    };
                    product1.Prices.Add(price1);
                    product1.Prices.Add(price2);
                    // Customer 1
                    var customer0 = new Customer {Id = 1, FirstName = "Leslie", LastName = "McArthur"};
                    // Order 1
                    var order0 = new Order("DKK", "Lærkevang 23", "3, TH", "1234", "København", "", "Danmark", customer0,
                        product0, product1);

                    context.Orders.Add(order0);
                    context.SaveChanges();
                }
            }

            return 0;
        }

    }
}
