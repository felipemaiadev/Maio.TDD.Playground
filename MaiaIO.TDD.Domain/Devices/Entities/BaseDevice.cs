using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.EntityBase;

namespace MaiaIO.TDD.Domain.Devices.Entities
{
    public abstract class BaseDevice : Entity
    {

        public virtual long Id { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual TypeVendorEnum Vendor { get; protected set; }
        public virtual TypeDeviceEnum TypeDevice { get; protected set; }
        public virtual string VendorCodeUID { get; protected set; }
        public virtual string VendorSerialNumber { get; protected set; }


        protected BaseDevice()
        {

        }
    }

}
