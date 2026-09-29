using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class UserRoleDTO
{
    [JsonPropertyName("id")]
    public decimal? Id { get; set; }

    [JsonPropertyName("roldId")]
    public decimal? RoldId { get; set; }

    [JsonPropertyName("userId")]
    public decimal? UserId { get; set; }

    public static UserRoleDTO ConvertFrom(PAW.Models.UserRole userRole)
    {
        return new UserRoleDTO
        {
            Id = userRole.Id,
            RoldId = userRole.RoldId,
            UserId = userRole.UserId
        };
    }

    public static PAW.Models.UserRole ConvertTo(UserRoleDTO userRole)
    {
        return new PAW.Models.UserRole
        {
            Id = userRole.Id,
            RoldId = userRole.RoldId,
            UserId = userRole.UserId
        };
    }
}