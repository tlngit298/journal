using JournalApp.Domain.Common;
using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Aggregates.JournalEntry.ValueObjects
{
    public sealed class Title : IValueObject
    {
        public string Value { get; }

        private Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new DomainException("Title cannot be null or empty.");
            }

            if (value.Length > 100)
            {
                throw new DomainException("Title cannot exceed 100 characters.");
            }

            Value = value.Trim();
        }

    }
}