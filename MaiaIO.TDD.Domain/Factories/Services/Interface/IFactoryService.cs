using MaiaIO.TDD.Domain.Factories.Commands;
using MaiaIO.TDD.Domain.Factories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Factories.Services.Interface
{
    public interface IFactoryService
    {

        public Task<Factory> GetAllFactories(FactoryGetListCommand command);

        public Task<Factory> GetByIdAsync(long id);
    }
}
