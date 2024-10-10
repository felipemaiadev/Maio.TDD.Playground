using MaiaIO.TDD.Domain.EntityBase;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.Domain.ProductionLines.Entities
{
    public class ProductionLine : Entity
    {
        public virtual long CodRef { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Descriptrion { get; protected set; }
        public virtual Factory Factory { get; protected set; }
        public virtual int MachineParts { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }
        public virtual DateTime LastUpdate { get; protected set; }



        public ProductionLine() { }
    }

}
