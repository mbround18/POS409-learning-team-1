using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS409_Learning_Team_1.Entities
{
    
    class Address
    {
        public Guid id;
        public string Address1;
        public string Address2;
        public string City;
        public string State;
        public string Country;
        public string ZipCode;

        public int Longtitude { get; set; }
        public int Latitude { get; set; }

        public Address(string address1, string address2 = "", string city = "", string state = "", string country = "", string zipCode = "")
        {
            id = Guid.NewGuid();
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        private List<string> GetPropList()
        {
            return  new List<string>() { id + "", Address1, Address2, City, State, Country, ZipCode };
        }

        public new string ToString()
        {
            return string.Join(", ", ToArray());
        }
        public string[] ToArray()
        {
            return GetPropList().ToArray();
        }
    }
}
