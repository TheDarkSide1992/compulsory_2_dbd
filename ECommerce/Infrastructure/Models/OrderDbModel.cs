namespace ECommerce.Infrastructure.Models;

public class OrderDbModel
{
    Guid UserId { get; set; }
    DateTime OrderDate { get; set; }
    List<ProductDbModel> Products { get; set; }
    double TotalPrice { get; set; }
}