using System.Text.Json.Serialization;

namespace PAW.Models.DTO; 

public class SupplierDTO
{
    //Id Supplier
    [JsonPropertyName("supplierId")]
    public int SupplierId { get; set; }

    //Name Supplier
    [JsonPropertyName("supplierName")]
    public string? SupplierName { get; set; }

    //Contact Name Supplier

    [JsonPropertyName("contactName")]
    public string? ContactName { get; set; }

    //Contact Title Supplier
    [JsonPropertyName("contactTitle")]
    public string? ContactTitle { get; set; }

    //Telephone
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    //Address
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    //City
    [JsonPropertyName("city")]
    public string? City { get; set; }

    //Country
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    //Last modified date
    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }

    //Modified by
    [JsonPropertyName("modifiedBy")]
    public string? ModifiedBy { get; set; }


    //Metodo para convertir de Supplier a SupplierDTO
    public static SupplierDTO ConvertFrom(PAW.Models.Supplier supplier)
    {
        return new SupplierDTO
        {
            SupplierId = supplier.SupplierId,
            SupplierName = supplier.SupplierName,
            ContactName = supplier.ContactName,
            ContactTitle = supplier.ContactTitle,
            Phone = supplier.Phone,
            Address = supplier.Address,
            City = supplier.City,
            Country = supplier.Country,
            LastModified = supplier.LastModified,
            ModifiedBy = supplier.ModifiedBy
        };

    }

    //Metodo para convertir de SupplierDTO a Supplier
    public static PAW.Models.Supplier ConvertTo(SupplierDTO supplierDTO)
    {
        return new PAW.Models.Supplier
        {
            SupplierId = supplierDTO.SupplierId,
            SupplierName = supplierDTO.SupplierName,
            ContactName = supplierDTO.ContactName,
            ContactTitle = supplierDTO.ContactTitle,
            Phone = supplierDTO.Phone,
            Address = supplierDTO.Address,
            City = supplierDTO.City,
            Country = supplierDTO.Country,
            LastModified = supplierDTO.LastModified,
            ModifiedBy = supplierDTO.ModifiedBy
        };
    }
}
