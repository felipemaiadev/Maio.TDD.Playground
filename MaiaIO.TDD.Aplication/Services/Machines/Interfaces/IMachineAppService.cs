using MaiaIO.TDD.API.DTO.Machines.Response;

namespace MaiaIO.TDD.API.Services.Machines.Interfaces
{
    public interface IMachineAppService
    {
        public Task<MachineDeviceResponse> GetMachineDeviceById(long machineId);
        public Task<bool> InsertRelationAsync(long machineId, long deviceId);
    }
}