using Petfolio.Communication_Request_e_Response.Enums_Tipo_de_Pet;
using Petfolio.Communication_Request_e_Response.Responses;

namespace Petfolio.Aplication_Business_Rule.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Pipoca",
            Type = PetType.Cat,
            Birthday = new DateTime(year: 2020, month: 10, day: 10)
        };
    }
}