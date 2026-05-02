using Petfolio.Communication_Request_e_Response.Enums_Tipo_de_Pet;

namespace Petfolio.Communication_Request_e_Response.Responses;

public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
