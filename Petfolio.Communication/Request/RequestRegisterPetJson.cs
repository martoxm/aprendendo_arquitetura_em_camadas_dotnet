using Petfolio.Communication_Request_e_Response.Enums_Tipo_de_Pet;

namespace Petfolio.Communication_Request_e_Response.Request;

public class RequestRegisterPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}