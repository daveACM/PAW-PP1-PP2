using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class NotificationDTO
{

    //Id Notification
    [JsonPropertyName("id")]
    public int Id { get; set; }

    //User ID
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    //Message of the notification
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    //Fue leido
    [JsonPropertyName("isRead")]
    public bool? IsRead { get; set; }

    //Fecha de creacion
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    //Metodo para convertir de Notification a NotificationDTO
    public static NotificationDTO ConvertFrom(PAW.Models.Notification notification)
    { 
        return new NotificationDTO
        {
            Id = notification.Id,
            UserId = notification.UserId,
            Message = notification.Message,
            IsRead = notification.IsRead,
            CreatedAt = notification.CreatedAt
        };

    }

    //Metodo para convertir de NotificationDTO a Notification
    public static PAW.Models.Notification ConvertTo(NotificationDTO notificationDTO)
    {
        return new PAW.Models.Notification
        {
            Id = notificationDTO.Id,
            UserId = notificationDTO.UserId,
            Message = notificationDTO.Message,
            IsRead = notificationDTO.IsRead,
            CreatedAt = notificationDTO.CreatedAt
        };
    }
}
