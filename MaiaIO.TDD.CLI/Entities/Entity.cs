using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.CLI.Entities
{
    public abstract class Entity
    {

        public Guid Id { get; set; }

        protected Entity()
        {
            
            Id = Guid.NewGuid();
        }
    }
}
