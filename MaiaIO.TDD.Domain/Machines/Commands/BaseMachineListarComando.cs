using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Enums;
using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.ProductionLines.Entities;

namespace MaiaIO.TDD.Domain.Machines.Commands
{
    public class BaseMachineListarComando 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string InventoryCode { get; set; }
        public long IdProductionLine { get; set; }
        public string ProductionLineName { get; set; }
        public TypeDeviceEnum VendornName { get; set; }
        public string DeviceName { get; set; }
        
    }
}
