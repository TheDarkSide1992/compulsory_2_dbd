using ECommerce.Domain.Interfaces;

namespace ECommerce.Domain.Events;

public class CacheInvaldiatedEvent : IDomainEvent
{
    public bool ShouldInvalidate { get; set; }
}