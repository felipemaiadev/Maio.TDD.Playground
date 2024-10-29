using MaiaIO.TDD.Aplication.Services.ProductionLines.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MaiaIO.TDD.API.Controllers.ProductionLine
{
    [ApiController]
    [Route("api/production-lines")]
    public class ProductionLineController(IProductionLineAppService productionLineAppService) : Controller
    {
        [HttpGet]
        public async  Task<ActionResult> List()
        {
            return Ok(await productionLineAppService.GetAllProductionLinesAsync());
        }

    }
}
