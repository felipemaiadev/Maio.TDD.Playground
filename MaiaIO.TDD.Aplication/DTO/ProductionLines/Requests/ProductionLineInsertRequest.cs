namespace MaiaIO.TDD.Aplication.DTO.ProductionLines.Requests
{
    public class ProductionLineInsertRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Descriptrion { get; set; }
        public long IdFactory { get; set; }
        public bool IsActive { get; set; }
    }
}
