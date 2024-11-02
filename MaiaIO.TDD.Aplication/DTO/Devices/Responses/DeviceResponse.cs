using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.Machines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Aplication.DTO.Devices.Responses
{
    public class DeviceResponse
    {
        public  long Id { get;  set; }
        public  string Description { get;  set; }
        public  TypeVendorEnum Vendor { get;  set; }
        public  TypeDeviceEnum TypeDevice { get;  set; }
        public  string VendorCodeUID { get;  set; }
        public  string VendorSerialNumber { get;  set; }
        public  int DeviceSID { get;  set; }
        public  string DeviceSUID { get;  set; }
    }
}
