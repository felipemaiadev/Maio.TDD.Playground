using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Devices.Repositories;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Infra.Devices.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        public async Task<BaseDevice> GetByIdAsync(long id)
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();
            var result = await  session.Query<BaseDevice>().Where(x => x.Id == id).FirstOrDefaultAsync();

            return result;
        }

        public async Task InsertAsync(BaseDevice entidade)
        {
            DbContext.Initialize();
            var session = DbContext.OpenSession();
            var transaction = session.BeginTransaction();
            await session.SaveAsync(entidade);
            transaction.Commit();
        }
    }
}
