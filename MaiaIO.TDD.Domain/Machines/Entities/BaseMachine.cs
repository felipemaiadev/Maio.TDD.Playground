using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.ProductionLines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Machines.Entities
{
    public class BaseMachine : Entity
    {
        public virtual long Id { get; protected set; }
        public virtual long IdProductionLine { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string InventoryCode { get; protected set; }
        public virtual ProductionLine ProductionLine { get; protected set; }
        public virtual IList<BaseDevice> DeviceList { get; protected set; }

        public BaseMachine() 
        { 
            this.SetDeviceList(new List<BaseDevice>());
        }

        public virtual void SetDeviceList(IList<BaseDevice> deviceList)
         {
            this.DeviceList = deviceList;
        }

    }
}
