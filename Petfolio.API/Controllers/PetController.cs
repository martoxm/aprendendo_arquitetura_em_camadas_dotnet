using Microsoft.AspNetCore.Mvc;
using Petfolio.Communication_Request_e_Response.Request;
using Petfolio.Communication_Request_e_Response.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPetJson request)
    {

        //business logic to register pet
        return Created();
    }
}