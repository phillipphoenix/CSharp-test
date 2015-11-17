using System;
using System.Collections.Generic;

namespace Opg2.Entities
{
    class Order
    {

        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public float TotalPrice { get; set; }
        public string Currency { get; set; }
        public OrderStatus Status { get; set; }
        public string TrackAndTraceNb { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<Product> Products { get; set; }


        public Order()
        {
            Products = new List<Product>();
        }

        public Order(string currency, string address1, string address2, string postalCode, string city, string state,
            string country, Customer customer, params Product[] products) : this()
        {
            OrderDateTime = DateTime.Now;
            Currency = currency;
            Address1 = address1;
            Address2 = address2;
            PostalCode = postalCode;
            City = city;
            State = state;
            Country = country;
            Customer = customer;

            foreach (var p in products)
            {
                Products.Add(p);
                TotalPrice += p.GetCurrentPrice().Value;
            }

            Status = OrderStatus.Unshipped;
        }

    }

    enum OrderStatus
    {
        Unshipped,
        Shipped,
        Canceled
    }
}
