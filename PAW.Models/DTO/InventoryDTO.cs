using System.Text.Json.Serialization;

namespace PAW.Models.DTO;

public class InventoryDTO
{
    //Id Inventory
    [JsonPropertyName("inventoryId")]
    public int InventoryId { get; set; }

    //UnitPrice
    [JsonPropertyName("unitPrice")]
    public decimal? UnitPrice { get; set; }

    //Unidades en stock
    [JsonPropertyName("unitsInStock")]
    public int? UnitsInStock { get; set; }

    //LastUpdate
    [JsonPropertyName("lastUpdated")]
    public DateTime? LastUpdated { get; set; }


    //Id Producto que es el Foreign Key
    [JsonPropertyName("productId")]
    public int? ProductId { get; set; }

    //Dia que se añadio
    [JsonPropertyName("dateAdded")]
    public DateTime? DateAdded { get; set; }

    //Modificado por
    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }

    //Metodo para convertir un Inventory a InventoryDTO
    public static InventoryDTO ConvertFrom(PAW.Models.Inventory inventory)
    {
        return new InventoryDTO
        {
            InventoryId = inventory.InventoryId,
            UnitPrice = inventory.UnitPrice,
            UnitsInStock = inventory.UnitsInStock,
            LastUpdated = inventory.LastUpdated,
            ProductId = inventory.ProductId,
            DateAdded = inventory.DateAdded,
            ModifiedBy = inventory.ModifiedBy
        };
    }

    //Metodo para convertir un InventoryDTO a Inventory
    public static PAW.Models.Inventory ConvertTo(InventoryDTO inventoryDTO)
    {
        return new PAW.Models.Inventory
        {
            InventoryId = inventoryDTO.InventoryId,
            UnitPrice = inventoryDTO.UnitPrice,
            UnitsInStock = inventoryDTO.UnitsInStock,
            LastUpdated = inventoryDTO.LastUpdated,
            ProductId = inventoryDTO.ProductId,
            DateAdded = inventoryDTO.DateAdded,
            ModifiedBy = inventoryDTO.ModifiedBy
        };
    }


}
