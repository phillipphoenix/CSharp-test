using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Opg2.Entities
{
    class Product
    {

        [Key]
        public string ProductNb { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Price> Prices { get; set; }
        public virtual List<Order> Orders { get; set; }

        public Product()
        {
            Prices = new List<Price>();
        }

        // Get the currently active price, if any.
        public Price GetCurrentPrice() => Prices.Where(p => p.FromDate <= DateTime.Now).OrderBy(p => p.FromDate).LastOrDefault();
    }
}
