namespace ECommerce.Infrastructure.Models;

public class ReviewDbModel
{
    string ReviewId { get; set; }
    Guid ReviewedUserId { get; set; }
    Guid AuthorUserId { get; set; }
    string Description { get; set; }
}