namespace ECommerce.Infrastructure.Models;

public class MediaDbModel
{
    string Media_Id { get; set; }
    string product_id { get; set; }
    string object_key { get; set; }
    string mime_type { get; set; }
    string size_bytes { get; set; }
    DateTime uploaded_at { get; set; }
    bool processed { get; set; }
}