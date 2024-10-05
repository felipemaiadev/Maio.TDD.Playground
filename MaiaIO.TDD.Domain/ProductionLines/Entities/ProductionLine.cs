using MaiaIO.TDD.Domain.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.ProductionLines.Entities
{
    public class ProductionLine : Entity
    {
        public virtual string Name { get; protected set; }
        public virtual long CodRef { get; protected set; }
        public ProductionLine() { } 
    }

}
