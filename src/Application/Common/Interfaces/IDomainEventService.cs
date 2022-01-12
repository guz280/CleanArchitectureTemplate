using CleanArchitectureTemplate.Domain.Common;

namespace CleanArchitectureTemplate.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
