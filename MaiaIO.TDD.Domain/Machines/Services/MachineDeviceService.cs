using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Machines.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.TDD.Domain.Machines.Services
{
    public class MachineDeviceService(IMachineRepository machineRepository) : IMachineDeviceService
    {
        public void InsertAsync(MachineDevice machineDevice)
        {
            machineRepository.InsertAsync(machineDevice);
        }
    }
}
