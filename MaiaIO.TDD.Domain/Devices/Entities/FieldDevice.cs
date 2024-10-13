using MaiaIO.TDD.Domain.Devices.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Entities
{
    public class FieldDevice : BaseDevice
    {

        public virtual TypeFieldDeviceEnum TypeFieldDevice { get; set; }

        
        public FieldDevice() { }
    }
}
