using MaiaIO.TDD.API.DataTransfer.Factories.Command;
using MaiaIO.TDD.Domain.Factories.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MaiaIO.TDD.API.Controllers.Factories
{
    [ApiController]
    public class FactoryController : MainController
    {


        public FactoryController()
        {
            
        }

        public ActionResult Inserir([FromBody] FactoryInsertModel model)
        {

            if (model == null) return CustomReponse(ModelState);

            var result = new { id = 1 };

            return CustomRespose(result);
        }
    }
}
