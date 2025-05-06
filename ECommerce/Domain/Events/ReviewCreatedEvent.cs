using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Events;

public class ReviewCreatedEvent
{
    public ReviewModel ReviewModel { get; set; }
}