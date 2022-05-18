using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQJoin
{
    class Address
    {
        public int addressId;
        public string addressLine;

        public static List<Address> GetAlladdress() => new List<Address>()
            {
                new Address { addressId = 1, addressLine = "AddressLine1" },
                new Address { addressId = 2, addressLine = "AddressLine2" },
                new Address { addressId = 3, addressLine = "AddressLine3" },
                new Address { addressId = 4, addressLine = "AddressLine4" },
                new Address { addressId = 5, addressLine = "AddressLine5" },
                new Address { addressId = 9, addressLine = "AddressLine9" },
                new Address { addressId = 10, addressLine = "AddressLine10" },
                new Address { addressId = 11, addressLine = "AddressLine11" }

            };
    }
}
