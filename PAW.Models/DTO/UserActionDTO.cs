using System.Text.Json.Serialization;

namespace PAW.Models.DTO;


public class UserActionDTO
{
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    // Convierte una entidad UserAction del modelo en un UserActionDTO
    public static UserActionDTO ConvertFrom(PAW.Models.UserAction userAction)
    {
        return new UserActionDTO
        {
            Id = userAction.Id,
            Name = userAction.Name,
            Description = userAction.Description
        };
    }

    // Convierte un UserActionDTO nuevamente en una entidad UserAction
    public static PAW.Models.UserAction ConvertTo(UserActionDTO userAction)
    {
        return new PAW.Models.UserAction
        {
            Id = userAction.Id,
            Name = userAction.Name,
            Description = userAction.Description
        };
    }
}