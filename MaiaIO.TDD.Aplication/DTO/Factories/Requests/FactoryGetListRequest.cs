using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.API.DTO.Factories.Requests
{
    public class FactoryGetListRequest
    {
        public  long Id { get;  set; }
        public  string Name { get;  set; }
        public  string Description { get;  set; }
        public  string Country { get;  set; }
        public  bool IsActive { get;  set; }
        public  DateTime AssemblyStamp { get;  set; }
    }
}
