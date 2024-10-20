using MaiaIO.TDD.Domain.ProductionLines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Factories.Commands
{
    public class FactoryGetListCommand
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public IList<ProductionLine> Lines { get; set; }
        public bool IsActive { get; set; }
        public DateTime AssemblyStamp { get; set; }
    }
}
