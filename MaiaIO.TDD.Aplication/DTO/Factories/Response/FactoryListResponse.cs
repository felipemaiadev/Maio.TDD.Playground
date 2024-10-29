using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.API.DTO.Factories.Response
{
    public class FactoryListResponse
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; protected set; }
        public virtual string Description { get; protected set; }
        public virtual string Country { get; protected set; }
        public virtual IList<ProductionLine> Lines { get; protected set; }
        public virtual bool IsActive { get; protected set; }
        public virtual DateTime AssemblyStamp { get; protected set; }

    }
}
