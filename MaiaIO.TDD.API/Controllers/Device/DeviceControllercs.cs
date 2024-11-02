using MaiaIO.TDD.Aplication.DTO.Devices.Requests;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
using MaiaIO.TDD.Aplication.Services.Devices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MaiaIO.TDD.API.Controllers.Device
{
    public class DeviceControllercs(IDeviceAppService deviceAppService) : Controller
    {

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] DeviceInsertRequest request)
        {
            await deviceAppService.InsertAsync(request);
            return Ok();
        }
    }
}
