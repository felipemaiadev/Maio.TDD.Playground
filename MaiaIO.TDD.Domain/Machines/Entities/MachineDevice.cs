using MaiaIO.TDD.Domain.Devices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Machines.Entities
{
    public  class MachineDevice
    {

        public virtual long Id { get; protected set; }
        public virtual Guid UID { get; protected set; }
        public virtual string MachineDescription { get; protected set; }
        public virtual BaseMachine Machine { get; protected set; }
        public virtual BaseDevice Device { get; protected set; }
        public virtual bool Status { get; protected set; }
        public MachineDevice()
        {
            
        }


    }
}
