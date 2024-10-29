using MaiaIO.TDD.Domain.Factories.Entities;
using MaiaIO.TDD.Domain.Machines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.ProductionLines.Entities
{
    public class ProductionLineDTO
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Descriptrion { get; set; }
        public long IdFactory { get; set; }
        public string FactoryName { get; set; }
        public IEnumerable<BaseMachine> Machines { get; set; }
        public bool IsActive { get; set; }
        public DateTime AssemblyStamp { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
