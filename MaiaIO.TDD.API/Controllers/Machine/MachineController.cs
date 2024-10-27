using MaiaIO.TDD.API.Services.Machines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MaiaIO.TDD.API.Controllers.Machine
{

    [ApiController]
    [Route("api/machines")]
    public class MachineController : ControllerBase
    {
        public readonly IMachineAppService _machineAppService;
        public MachineController(IMachineAppService machineAppService)
        {
            _machineAppService = machineAppService;
        }

        /// <summary>
        /// Get Machine By ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            var result = await _machineAppService.GetMachineDeviceById(id);
            return Ok(result);
        }
    }
}
