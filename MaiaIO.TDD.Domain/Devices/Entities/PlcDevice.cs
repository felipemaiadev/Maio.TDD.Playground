using MaiaIO.TDD.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Entities
{
    public class PlcDevice : BaseDevice
    {

        public virtual int SerialCommunicationPorts { get; protected set; }

        public virtual IEnumerable<SerialProtocolsEnum> SerialProtocols{ get; protected set; }

        public virtual int EthernetCommunicationPorts { get; protected set; }

        public virtual IEnumerable<SerialProtocolsEnum> EthernetProtocols { get; protected set; }

        public PlcDevice()
        {
            
        }
    }
}
