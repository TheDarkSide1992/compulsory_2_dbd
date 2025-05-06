using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;

namespace ECommerce.Domain.Events;

public class ListingChangedEvent : IDomainEvent
{
    public ListingModel ListingModel { get; set; }
}