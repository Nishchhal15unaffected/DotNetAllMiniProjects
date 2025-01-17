using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressLibrary;

namespace AddressBookLibrary
{
    public interface ISave
    {
        void SaveAddress(AddressModel addressModel);
    }
}
