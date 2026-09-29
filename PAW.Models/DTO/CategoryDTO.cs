using System.Text.Json.Serialization;

namespace PAW.Models.DTO
{
    public class CategoryDTO
    {

        //ID Categoria
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        //Nombre Categoria
        [JsonPropertyName("categoryName")]
        public string? CategoryName { get; set; }

        //Descripcion Categoria
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        //Ultima fecha de modificacion
        [JsonPropertyName("lastModified")]
        public DateTime? LastModified { get; set; }

        //Registro de que usuario la modifico
        [JsonPropertyName("modifiedBy")]
        public string? ModifiedBy { get; set; }

        //Convertir de Category a CategoryDTO
        public static CategoryDTO ConvertFrom(Category category)
        {
            return new CategoryDTO
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description,
                LastModified = category.LastModified,
                ModifiedBy = category.ModifiedBy
            };
        }
        //Convertir de CategoryDTO a Category
        public static Category ConvertTo(CategoryDTO categoryDTO)
        {
            return new Category
            {
                CategoryId = categoryDTO.CategoryId,
                CategoryName = categoryDTO.CategoryName,
                Description = categoryDTO.Description,
                LastModified = categoryDTO.LastModified,
                ModifiedBy = categoryDTO.ModifiedBy
            };
        }
    }
}
