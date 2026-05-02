using Petfolio.Communication_Request_e_Response.Request;
using Petfolio.Communication_Request_e_Response.Responses;

namespace Petfolio.Aplication_Business_Rule.UseCases.Pets.Register;

public class RegisterPetUsecase
{
    public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson
        {
            Id = 7,
            Name = request.Name,
        };

        //business logic to register pet
    }
}