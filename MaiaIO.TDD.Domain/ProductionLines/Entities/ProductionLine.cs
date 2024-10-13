using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Machines.Entities;
using System.Reflection.PortableExecutable;

namespace MaiaIO.TDD.Domain.ProductionLines.Entities
{
    public class ProductionLine : Entity
    {
        public virtual long Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Descriptrion { get; protected set; }
        public virtual long IdFactory { get; protected set; }
        public virtual Factory Factory { get; protected set; }
        public virtual IList<BaseMachine> Machines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }
        public virtual DateTime LastUpdate { get; protected set; }

        public ProductionLine() 
        { 
            this.SetMachines(new List<BaseMachine>());
        }

        public virtual void SetMachines(IList<BaseMachine> machines)
        {
            Machines = machines;
        }
    }

}
