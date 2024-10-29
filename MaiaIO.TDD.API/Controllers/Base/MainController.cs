using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace MaiaIO.TDD.API.Controllers.Base
{
    public abstract class MainController : Controller
    {

        public MainController()
        {

        }

        //public Task<ActionResult> CustomResponse(object response)
        //{
        //    var result = new CustomResponse();

        //    if (response == null) return FailResponse(result);

        //    return ResponseValid(result);

        //}

        //protected Task<ActionResult> ResponseValid(CustomResponse response) 
        //{
        //    response.status = true;
        //    response.responseData = res
        //    return Ok(response);
        //}

        public class CustomResponse 
        {
            public bool status {  get; init; } = false;
            public object responseData { get; init; } = new object();
        }

    }
}
