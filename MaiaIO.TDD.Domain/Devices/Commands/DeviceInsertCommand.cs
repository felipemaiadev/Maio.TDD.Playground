using MaiaIO.TDD.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Commands
{
    public  class DeviceInsertCommand
    {
        public string Description { get; set; }
        public TypeVendorEnum Vendor { get; set; }
        public TypeDeviceEnum TypeDevice { get; set; }
        public string VendorCodeUID { get; set; }
        public string VendorSerialNumber { get; set; }
        public int DeviceSID { get; set; }
        public string DeviceSUID { get; set; }
        public long MachinesId { get; set; }
    }
}
