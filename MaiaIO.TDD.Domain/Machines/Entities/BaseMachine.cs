using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Machines.Entities
{
    public class BaseMachine : Entity
    {
        public virtual string Name { get; set; }

        public virtual IEnumerable<BaseDevice> DeviceList { get; set; }

        public BaseMachine() { }
    }
}
