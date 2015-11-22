using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg2.Entities
{
    class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public Address(string address1, string address2, string postalCode, string city, string state, string country)
        {
            Address1 = address1;
            Address2 = address2;
            PostalCode = postalCode;
            City = city;
            State = state;
            Country = country;
        }
    }
}
