using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;

namespace ECommerce.Domain.Events;

public class ListingCreatedEvent: IDomainEvent
{
    public ListingModel ListingModel { get; set; }
}