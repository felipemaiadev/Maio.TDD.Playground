using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Entities
{
    public class DriverDevice : BaseDevice
    {

        public virtual decimal HP { get; protected set; }
        public virtual decimal Current { get; protected set; }

        public DriverDevice() { }
    }
}
