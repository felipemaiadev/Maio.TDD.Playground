using AutoMapper;
using MaiaIO.TDD.API.DTO.Machines.Response;
using MaiaIO.TDD.API.Services.Machines.Interfaces;
using MaiaIO.TDD.Domain.Machines.Repositories.Interfaces;

namespace MaiaIO.TDD.API.Services.Machines
{
    public class MachineAppService(IMachineRepository machineRepository, IMapper mapper) : IMachineAppService
    {

        public async Task<MachineDeviceResponse> GetMachineDeviceById(long machineId)
        {

            var response = await machineRepository.GetMachineDevicesById(machineId);

            var mappedResult = mapper.Map<MachineDeviceResponse>(response);

            return mappedResult;
        }

    }
}
