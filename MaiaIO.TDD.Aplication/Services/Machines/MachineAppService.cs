using AutoMapper;
using MaiaIO.TDD.API.DTO.Machines.Response;
using MaiaIO.TDD.API.Services.Machines.Interfaces;
using MaiaIO.TDD.Domain.Devices.Entities;
using MaiaIO.TDD.Domain.Machines.Entities;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;
using MaiaIO.TDD.Domain.Machines.Services.Interfaces;

namespace MaiaIO.TDD.API.Services.Machines
{
    public class MachineAppService(IMapper mapper,
                                   IMachineRepository machineRepository,
                                   IMachineDeviceService machineDeviceService ) : IMachineAppService
    {

        public async Task<MachineDeviceResponse> GetMachineDeviceById(long machineId)
        {

            var response = await machineRepository.GetMachineDevicesById(machineId);

            var mappedResult = mapper.Map<MachineDeviceResponse>(response);

            return mappedResult;
        }

        public async Task<bool> InsertRelationAsync(long machineId, long deviceId)
        {

           MachineDeviceDTO baseMachine =  await machineRepository.GetMachineDevicesById(machineId);
           //BaseDevice baseDevice = await deviceRepository
           // await machineDeviceService.InsertAsync();

            return true;
        }
    }
}
