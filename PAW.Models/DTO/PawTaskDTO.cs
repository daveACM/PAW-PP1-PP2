using System.Text.Json.Serialization;
using PawTask = PAW.Models.Task;


namespace PAW.Models.DTO;

public class PawTaskDTO
{
    //IdTask
    [JsonPropertyName("id")]
    public int Id { get; set; }

    //Name
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    //Description
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    //Status
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    //DueDate
    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }

    //CreatedAt
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    //Lastmodified
    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    //ModifiedBy
    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }


    //Metodo para convertir un PawTask a PawTaskDTO
    public static PawTaskDTO ConvertFrom(PawTask task)
    {
        return new PawTaskDTO
        {
            Id = task.Id,
            Name = task.Name,
            Description = task.Description,
            Status = task.Status,
            DueDate = task.DueDate,
            CreatedAt = task.CreatedAt,
            LastModified = task.LastModified,
            ModifiedBy = task.ModifiedBy
        };
    }

    //Metodo para convertir un PawTaskDTO a PawTask
    public static PawTask ConvertTo(PawTaskDTO taskDTO)
    {
        return new PawTask
        {
            Id = taskDTO.Id,
            Name = taskDTO.Name,
            Description = taskDTO.Description,
            Status = taskDTO.Status,
            DueDate = taskDTO.DueDate,
            CreatedAt = taskDTO.CreatedAt,
            LastModified = taskDTO.LastModified,
            ModifiedBy = taskDTO.ModifiedBy
        };
    }
}
