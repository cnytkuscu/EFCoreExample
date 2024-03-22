using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TyeBank.Core.DTOs;

namespace TyeBank.API.Controllers
{

    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDTO<T> response)
        {
            //204 - NoContent
            if (response.StatusCode == 204) return new ObjectResult(null)
            {
                StatusCode = response.StatusCode
            };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
