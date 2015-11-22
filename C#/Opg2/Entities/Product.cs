using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Opg2.Entities
{
    /// <summary>
    /// A product holds information about a product sold through the shop.
    /// This means its product number, which is unique, a name and a discription.
    /// </summary>
    class Product
    {

        [Key]
        public string ProductNb { get; set; } // The products product number and the primary key.
        public string Name { get; set; } // The name of the product.
        public string Description { get; set; } // The description of the product.

        public virtual List<Price> Prices { get; set; } // References to the product's prices.
        public virtual List<Order> Orders { get; set; } // References to the orders the product are in.

        public Product()
        {
            Prices = new List<Price>();
        }

        // Get the currently active price, if any.
        public Price GetCurrentPrice() => Prices.Where(p => p.FromDate <= DateTime.Now).OrderBy(p => p.FromDate).LastOrDefault();
    }
}
