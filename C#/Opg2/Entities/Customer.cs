

using System.Collections.Generic;

namespace Opg2.Entities
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address CurrentAddress { get; set; }

        public virtual List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
