using MaiaIO.TDD.Domain.Machines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Machines.Services.Interfaces
{
    public interface IMachineDeviceService
    {
      public void InsertAsync(MachineDevice machineDevice);
    }
}
