using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Aggregates.JournalEntry.Events
{
    public record JournalEntryCreatedEvent(JournalEntry JournalEntry) : IDomainEvent
    {
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
    }
}