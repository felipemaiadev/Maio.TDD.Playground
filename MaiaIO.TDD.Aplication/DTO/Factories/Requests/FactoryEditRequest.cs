namespace MaiaIO.TDD.Aplication.DTO.Factories.Requests
{
    public class FactoryEditRequest
    {
        public  Guid UID { get; set; }
        public  long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
    }
}
