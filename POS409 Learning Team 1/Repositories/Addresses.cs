using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS409_Learning_Team_1.Repositories
{
    class Addresses
    {
        private static List<Entities.Address> collection = new List<Entities.Address>();
        public static Entities.Address Read(Guid id)
        {
            return collection.Where(address => address.id == id).FirstOrDefault();
        }
        public static List<Entities.Address> All()
        {
            return collection.ToList();
        }
        public static Entities.Address Create(string address1, string address2 = "", string city = "", string state = "", string country = "", string zipCode = "")
        {
            Entities.Address addr = new Entities.Address(address1, address2, city, state, country, zipCode);
            collection.Add(addr);
            return addr;
        }
        public static Entities.Address Update(Entities.Address address)
        {
            try
            {
                int index = collection.IndexOf(collection.Where(addr => addr.id == address.id).FirstOrDefault());
                collection.RemoveAt(index);
                collection.Insert(index - 1, address);
                return Read(address.id);
            } catch (ArgumentOutOfRangeException)
            {
                collection.Add(address);
                return address;
            }            
        }
        public static void Delete(Guid id)
        {
            try
            {
                int index = collection.IndexOf(collection.Where(addr => addr.id == id).FirstOrDefault());
                collection.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
            
            }
        }
    }
}
