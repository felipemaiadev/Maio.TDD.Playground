using MaiaIO.TDD.API.Services.Factories.Interfaces;
using MaiaIO.TDD.Aplication.DTO.Factories.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MaiaIO.TDD.API.Controllers.Factories
{

    [ApiController]
    [Route("api/factories")]
    public class FactoryController(IFactoryAppService factoryAppService) : Controller
    {


        /// <summary>
        /// Lista todas as Fabricas 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> List()
        {
            var result = await factoryAppService.ListarAsync();
            return Ok(result);
        }

        /// <summary>
        /// Pesquisa uma fabrica pelo Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id:long}")]
        public async Task<ActionResult> GetById([FromRoute] long id)
        {
            var result = await factoryAppService.GetByIdAsync(id);
            return Ok(result);
        }

        /// <summary>
        /// Insere uma nova fabrica na Lista
        /// </summary>
        /// <param name="factoryInsertRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] FactoryInsertRequest factoryInsertRequest)
        {
            return Ok(await factoryAppService.InsertAsync(factoryInsertRequest));
        }

        /// <summary>
        /// Altera dados de uma fabrica 
        /// </summary>
        /// <param name="factoryEditRequest"></param>
        /// <returns></returns>
        [HttpPatch]
        public async Task<ActionResult> Editar([FromBody] FactoryEditRequest factoryEditRequest)
        {
            return Ok(await factoryAppService.EditAsync(factoryEditRequest));
        }

        /// <summary>
        /// Altera dados de uma fabrica 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:long}")]
        public async Task<ActionResult> Excluir([FromRoute] long id)
        {
            return Ok(await factoryAppService.RemoveByIdAsync(id));
        }

    }
}
