using MediatR;

namespace JournalApp.Domain.Common.Interfaces
{
    public interface IDomainEvent : INotification
    {
        public DateTime OccurredOn { get; }
    }
}