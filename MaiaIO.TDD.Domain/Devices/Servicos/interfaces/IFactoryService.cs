using MaiaIO.TDD.Domain.Factories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Servicos.interfaces
{
    public interface IFactoryService
    {
        Factory InsertAsync(Factory factory);
        Factory UpdateAsync(Factory factory);
        Factory DeleteAsync(Factory factory);
        IEnumerable<Factory> GetListAsync(); 
        Factory GetByIdAsync(long id);
    }
}
