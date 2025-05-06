using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;

namespace ECommerce.Domain.Events;

public class ReviewChangedEvent: IDomainEvent
{
    public ReviewModel ReviewModel { get; set; }
}