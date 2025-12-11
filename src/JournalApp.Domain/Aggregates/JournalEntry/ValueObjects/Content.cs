using JournalApp.Domain.Common;
using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Aggregates.JournalEntry.ValueObjects
{
    public sealed class Content : IValueObject
    {
        public string Value { get; }

        private Content(string value)
        {
            if (value == null) value = "";

            Value = value.Trim();
        }
    }
}