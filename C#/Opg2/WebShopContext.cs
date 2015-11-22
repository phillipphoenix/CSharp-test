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

    /// <summary>
    /// This is a very crude test class, only used to test that the basic setup of the entites
    /// was correct.
    /// </summary>
    class TestWebShopContext
    {
        static int Main(string[] args)
        {
            using (var context = new WebShopContext())
            {
                context.Products.RemoveRange(context.Products);
                context.Prices.RemoveRange(context.Prices);
                context.Customers.RemoveRange(context.Customers);
                context.Orders.RemoveRange(context.Orders);
                
                // Product 1
                var price0 = new Price
                {
                    Id = 1,
                    FromDate = DateTime.Now,
                    Value = 100,
                    Currency = "DKK"
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
                    Currency = "DKK"
                };
                var price2 = new Price
                {
                    Id = 3,
                    FromDate = DateTime.Now,
                    Value = 399,
                    Currency = "DKK"
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
                var customer0 = new Customer { Id = 1, FirstName = "Leslie", LastName = "McArthur", CurrentAddress = new Address("Lærkevang 23", "3, TH", "1234", "København", "", "Danmark") };
                // Order 1
                var order0 = new Order("DKK", customer0.CurrentAddress, customer0,
                    product0, product1);
                order0.Id = 1;

                context.Orders.Add(order0);
                context.SaveChanges();
            }

            return 0;
        }

    }
}
