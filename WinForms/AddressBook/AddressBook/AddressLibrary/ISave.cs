using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLibrary
{
    public interface ISave
    {
       void SaveAdress(AddressModel address);
    }
}
