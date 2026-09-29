using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

// DTO utilizado para transferir la información de un usuario entre las diferentes capas de la aplicación.
public class UserDTO
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }

    [JsonPropertyName("roleId")]
    public int? RoleId { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    // Convierte una entidad User del modelo en un UserDTO
    public static UserDTO ConvertFrom(PAW.Models.User user)
    {
        return new UserDTO
        {
            UserId = user.UserId,
            Username = user.Username,
            Email = user.Email,
            CreatedAt = user.CreatedAt,
            IsActive = user.IsActive,
            LastModified = user.LastModified,
            ModifiedBy = user.ModifiedBy,
            RoleId = user.RoleId,
            LastModifiedBy = user.LastModifiedBy
        };
    }

    // Convierte un UserDTO nuevamente en una entidad User 
    public static PAW.Models.User ConvertTo(UserDTO user)
    {
        return new PAW.Models.User
        {
            UserId = user.UserId,
            Username = user.Username,
            Email = user.Email,
            CreatedAt = user.CreatedAt,
            IsActive = user.IsActive,
            LastModified = user.LastModified,
            ModifiedBy = user.ModifiedBy,
            RoleId = user.RoleId,
            LastModifiedBy = user.LastModifiedBy
        };
    }
}