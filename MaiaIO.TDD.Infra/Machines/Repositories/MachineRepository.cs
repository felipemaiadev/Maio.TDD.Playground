using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Infra.Machines.Repositories
{
    public class MachineRepository : IMachineRepository
    {
        public async Task<BaseMachine> GetMachineDevicesById(long id)
        {
            var session = DbContext.OpenSession();

            var result  =  await session.Query<BaseMachine>().FirstOrDefaultAsync(x => x.Id == id); 

            return result;
        }
    }
}
