using Microsoft.AspNetCore.Mvc;
using Petfolio.Aplication_Business_Rule.UseCases.Pet.Register;
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
        var useCase = new RegisterPetUsecase();

        var reponse = useCase.Execute(request);

        
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        return NoContent();
    }
}