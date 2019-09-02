using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS409_Learning_Team_1.Entities
{
    
    class Address
    {
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
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
        }

        public new string ToString
        {
            get
            {
                List<string> props = new List<string>() { Address1, City, State, Country, ZipCode };
                if (Address2 != string.Empty)
                {
                    props.Insert(1, Address2);
                }
                return string.Join(", ", props.ToArray());
            }
        }
    }
}
