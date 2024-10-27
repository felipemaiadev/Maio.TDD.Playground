using MaiaIO.TDD.Domain.ProductionLines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Aplication.DTO.Factories.Requests
{
    public class FactoryInsertRequest
    {
        public  string Name { get;  set; }
        public  string Description { get;  set; }
        public  string Country { get;  set; }
        public  bool IsActive { get;  set; }



    }
}
