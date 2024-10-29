using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
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
        public async Task<ActionResult> GetById([FromRoute] long id)
        {

            var result = await _factoryAppService.GetByIdAsync(id);

            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] FactoryInsertRequest factoryInsertRequest)
        {
            return Ok(await _factoryAppService.InsertAsync(factoryInsertRequest));
        }
    }

}
