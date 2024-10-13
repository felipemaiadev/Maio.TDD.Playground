using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Enums
{
    public enum EthernetProtocols
    {

        TCP = 0,
        ModbusTCP = 1,
        Profinet = 2,
        Ethernet_IP = 3,
        OPCDA = 4,
        OPCUA = 5
    }
}
