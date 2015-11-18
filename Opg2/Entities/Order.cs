using System;
using System.Collections.Generic;

namespace Opg2.Entities
{
    /// <summary>
    /// An order is placed by a customer and consists of products ordered by that customer.
    /// It also knows the customers delivery address, the track&trace number, if any, and the total price of the order.
    /// </summary>
    class Order
    {

        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; } // The date and time the order was placed.
        public float TotalPrice { get; set; } // The total price of the order.
        public string Currency { get; set; } // The total price' currency.
        public OrderStatus Status { get; set; } // The status of the order. See enum below.
        public string TrackAndTraceNb { get; set; } // The track and trace number for tracing the package.
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } // The reference to the customer.
        public virtual List<Product> Products { get; set; } // The references to all the products in this order.


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

            // Add the products and increase the price.
            foreach (var p in products)
            {
                Products.Add(p);
                TotalPrice += p.GetCurrentPrice().Value;
            }

            Status = OrderStatus.Unshipped;
        }

    }

    /// <summary>
    /// The status of the order.
    /// </summary>
    enum OrderStatus
    {
        Unshipped,
        Shipped,
        Canceled
    }
}
