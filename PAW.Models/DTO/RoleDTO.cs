using System.Text.Json.Serialization;

namespace PAW.Models.DTO;


public class RoleDTO
{

    //Id
    [JsonPropertyName("roleId")]
    public int RoleId { get; set; }

    //Role name
    [JsonPropertyName("roleName")]
    public string? RoleName { get; set; }

    //Metodo para convertir un Role a RoleDTO
    public static RoleDTO ConvertFrom(PAW.Models.Role role)
    {
        return new RoleDTO
        {
            RoleId = role.RoleId,
            RoleName = role.RoleName
        };

    }

    //Metodo para convertir un RoleDTO a Role
    public static PAW.Models.Role ConvertTo(RoleDTO roleDTO)
    {
        return new PAW.Models.Role
        {
            RoleId = roleDTO.RoleId,
            RoleName = roleDTO.RoleName
        };
    }


}
