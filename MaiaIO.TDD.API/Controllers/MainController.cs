using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MaiaIO.TDD.API.Controllers
{
    public class MainController : ControllerBase
    {

        public MainController()
        {}


        public ActionResult CustomReponse(ModelStateDictionary model)
        {

           var errors = model.Values.SelectMany(x => x.Errors)
                                    .Select(x => new { x.ErrorMessage });

            if (errors.Any())
            {
                var response = new { Status = false, Erros = errors, Code=StatusCode(404) };
                return BadRequest(response);
            }

            return Ok();
        }

        public ActionResult CustomRespose(Object obj)
        {
            
            var result = new { Status = true, Result = obj, Code = StatusCode(200) };
            return Ok();

        }
    }
}
