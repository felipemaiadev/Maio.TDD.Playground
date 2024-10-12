using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Entities
{
    public abstract class BaseDevice : Entity
    {

        public virtual string Description { get; set; }
        public virtual TypeVendorEnum Vendor { get; set; }
        public virtual string VendorCodeUID { get; protected set; }
        public virtual string VendorCodeProductUID { get; protected set; }

    }

}
