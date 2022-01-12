using CleanArchitectureTemplate.Application.Common.Interfaces;

namespace CleanArchitectureTemplate.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
