namespace ECommerce.Domain.Entities;

public class OrderModel
{
    Guid UserId { get; set; }
    DateTime OrderDate { get; set; }
    List<ProductModel> Products { get; set; }
    double TotalPrice { get; set; }
}