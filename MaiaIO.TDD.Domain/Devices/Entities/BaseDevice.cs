using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.Machines.Entities;
using System.Reflection.PortableExecutable;

namespace MaiaIO.TDD.Domain.Devices.Entities
{
    public class BaseDevice : Entity
    {

        public virtual long Id { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual TypeVendorEnum Vendor { get; protected set; }
        public virtual TypeDeviceEnum TypeDevice { get; protected set; }
        public virtual string VendorCodeUID { get; protected set; }
        public virtual string VendorSerialNumber { get; protected set; }
        public virtual int DeviceSID { get; protected set; }
        public virtual string DeviceSUID { get; protected set; }
        public virtual IList<BaseMachine> Machines { get; protected set; }


        public BaseDevice (string description, TypeVendorEnum vendor, TypeDeviceEnum typeDevice, string vendorCodeUID, string vendorSerialNumber)
        {
            Description = description;
            Vendor = vendor;
            TypeDevice = typeDevice;
            VendorCodeUID = vendorCodeUID;
            VendorSerialNumber = vendorSerialNumber;
        }
        public BaseDevice()
        {

            this.SetMachines(new List<BaseMachine>());
        }



        public virtual void SetMachines(IList<BaseMachine> machines)
        {
            this.Machines = machines;
        }
    }

}
