using MaiaIO.TDD.Domain.Devices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Devices.Repositories
{
    public interface IDeviceRepository
    {
        public Task<BaseDevice> GetByIdAsync(long id);
        public Task InsertAsync(BaseDevice entidade);
    }
}
