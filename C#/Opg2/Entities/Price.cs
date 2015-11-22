using System;

namespace Opg2.Entities
{
    /// <summary>
    /// Each price indicates a price for a product at a specific time.
    /// The newest "valid" price will always be considered the current price.
    /// Sales prices can be created in advance and normal prices can be set for the products after the sales end.
    /// <example>
    /// A product costs 10 DKK from 1-1-2015 till the 1-2-2015, where the price will be 5 DKK.
    /// To do this, create two objects, one with the fromDate set to 1-1-2015 and one with the fromDate set to 1-2-2015.
    /// If the first one has a value of 10 and the second a value of 5, the price of 10 DKK will be used from the 1-1-2015 till the 31-1-2015
    /// after which the price of 5 will be used.
    /// </example>
    /// </summary>
    class Price
    {

        public int Id { get; set; }
        public DateTime FromDate { get; set; } // The date and time, from where this price is valid.
        public float Value { get; set; } // The value of the price.
        public string Currency { get; set; } // The currency of the price.

        public string ProductNb { get; set; } // The product number of the product this price belongs to.
        public virtual Product Product { get; set; }

    }
}
