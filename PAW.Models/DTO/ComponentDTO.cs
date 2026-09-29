using System.Text.Json.Serialization;


namespace PAW.Models.DTO
{
    public class ComponentDTO
    {

        //Id Component
        [JsonPropertyName("id")]
        public decimal Id { get; set; }

        //Name Component
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;


        //Content Component
        [JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        //Convertidor de Component para ComponentDTO
        public static ComponentDTO ConvertFrom(PAW.Models.Component component)
        {
            return new ComponentDTO
            {
                Id = component.Id,
                Name = component.Name,
                Content = component.Content
            };

        }

        //Convertidor de ComponentDTO para Component
        public static PAW.Models.Component ConvertTo(ComponentDTO componentDTO)
        {
            return new PAW.Models.Component
            {
                Id = componentDTO.Id,
                Name = componentDTO.Name,
                Content = componentDTO.Content
            };
        }
    }
}
