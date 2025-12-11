using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Aggregates.JournalEntry.ValueObjects
{
    public record JournalEntryId : IValueObject
    {
        public Guid Value { get; private set; }

        private JournalEntryId() {}

        private JournalEntryId(Guid value)
        {
            Value = value;
        }

        public static JournalEntryId Create(Guid value) => new (value);
        public static JournalEntryId CreateNew() => new (Guid.NewGuid());
    }
}