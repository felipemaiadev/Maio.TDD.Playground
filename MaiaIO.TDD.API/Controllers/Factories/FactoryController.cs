using MaiaIO.TDD.API.Services.Factories;
using MaiaIO.TDD.API.Services.Factories.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace MaiaIO.TDD.API.Controllers.Factories
{

    [ApiController]
    [Route("api/factories")]
    public class FactoryController : Controller
    {

        public readonly IFactoryAppService _factoryAppService;

        public FactoryController(IFactoryAppService factoryAppService) 
        {
            _factoryAppService = factoryAppService;
        }


        [HttpGet]
        public async Task<ActionResult> List()
        {

            var result = await _factoryAppService.ListarAsync();

            return Ok(result);
        }


        [HttpGet("{id:long}")]
        public async Task<ActionResult> GetById([FromQuery] long id)
        {

            var result = await _factoryAppService.GetByIdAsync(id);

            return Ok(result);
        }
    }

}
