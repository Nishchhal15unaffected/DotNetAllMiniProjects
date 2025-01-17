using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLibrary
{
    public class AddressModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string LandMark { get; set; }
        public string PostalCode { get; set; }
        public string AddressDisplayValue => $"{Address},{City},{LandMark},{PostalCode}";
    }
}
