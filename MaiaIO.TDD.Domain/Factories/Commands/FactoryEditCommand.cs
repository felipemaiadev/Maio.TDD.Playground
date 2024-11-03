using MaiaIO.TDD.Domain.EntityBase.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;

namespace MaiaIO.TDD.Domain.Factories.Commands
{
    public class FactoryEditCommand 
    {

        public Guid UID { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
    }
}
