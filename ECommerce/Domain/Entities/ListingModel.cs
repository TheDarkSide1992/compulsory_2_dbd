namespace ECommerce.Domain.Entities;

public class ListingModel
{
    string ProductId { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    int Stock { get; set; }
    double Price { get; set; }
    Guid SellderId { get; set; }
    
}