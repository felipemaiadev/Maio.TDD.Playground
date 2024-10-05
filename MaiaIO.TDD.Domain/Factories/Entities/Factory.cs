using MaiaIO.TDD.Domain.EntityBase;

namespace MaiaIO.TDD.Domain.Factories.Entities
{
    public class Factory : Entity
    {
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }

        public virtual IEnumerable<ProductionLine> }

        public Factory() { }
    }
}
