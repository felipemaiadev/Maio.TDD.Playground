namespace MaiaIO.TDD.Domain.ProductionLines.Commands
{
    public class ProductionLineListCommand
    {
        public Guid UIDProdutionLine { get; set; }
        public string ProductionLineName { get; set; }
        public string MachineName { get; set; }
        public string MachineInvetoryCode { get; set; }

    }
}
