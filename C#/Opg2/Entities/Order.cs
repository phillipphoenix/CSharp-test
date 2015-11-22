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
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public virtual Customer Customer { get; set; } // The reference to the customer.
        public virtual Address DeliveryAddress { get; set; } // The delivery address of the order.
        public virtual List<Product> Products { get; set; } // The references to all the products in this order.


        public Order()
        {
            Products = new List<Product>();
        }

        public Order(string currency, Address deliveryAddress, Customer customer, params Product[] products) : this()
        {
            OrderDateTime = DateTime.Now;
            Currency = currency;
            DeliveryAddress = deliveryAddress;
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
