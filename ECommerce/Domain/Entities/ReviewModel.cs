namespace ECommerce.Domain.Entities;

public class ReviewModel
{
    string ReviewId { get; set; }
    Guid ReviewedUserId { get; set; }
    Guid AuthorUserId { get; set; }
    string Description { get; set; }
}