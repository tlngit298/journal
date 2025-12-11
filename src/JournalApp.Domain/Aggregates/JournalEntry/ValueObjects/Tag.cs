using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Aggregates.JournalEntry.ValueObjects
{
    public sealed class Tag : IValueObject
    {
        public string Value { get; }

        private Tag(string value)
        {
            if (value == null) value = "";

            Value = value.Trim();
        }

    }
}