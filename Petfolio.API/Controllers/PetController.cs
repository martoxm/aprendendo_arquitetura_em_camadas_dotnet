using Microsoft.AspNetCore.Mvc;
using Petfolio.Aplication_Business_Rule.UseCases.Pets.GetAll;
using Petfolio.Aplication_Business_Rule.UseCases.Pets.Register;
using Petfolio.Aplication_Business_Rule.UseCases.Pets.Update;
using Petfolio.Communication_Request_e_Response.Request;
using Petfolio.Communication_Request_e_Response.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var useCase = new RegisterPetUsecase();

        var reponse = useCase.Execute(request);

        return Created(string.Empty, reponse);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        var usecase = new UpdatePetUseCase();

        usecase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseAllPetJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();

        var response = useCase.Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }
}