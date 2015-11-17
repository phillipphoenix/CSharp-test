using System;

namespace Opg2.Entities
{
    class Price
    {

        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public float Value { get; set; }
        public string Currency { get; set; }
        public bool OnSale { get; set; }

        public string ProductNb { get; set; }
        public virtual Product Product { get; set; }
    }
}
