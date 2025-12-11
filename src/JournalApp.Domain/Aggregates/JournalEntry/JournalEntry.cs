using JournalApp.Domain.Aggregates.JournalEntry.Events;
using JournalApp.Domain.Aggregates.JournalEntry.ValueObjects;
using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Aggregates.JournalEntry
{
    public class JournalEntry : AggregateRoot<JournalEntryId>
    {
        public JournalEntryId Id { get; private set; } = default!;
        public Title? Title { get; private set; }
        public Content? Content { get; private set; }
        public Tag? Tag { get; private set; }
        private readonly IList<Attachment> _attachments = new List<Attachment>();
        public IReadOnlyList<Attachment> Attachments => _attachments.ToList();

        private JournalEntry() { }
        public JournalEntry(JournalEntryId id, Title? title, Content? content, Tag? tag)
        {
            Id = id;
            Title = title;
            Content = content;
            Tag = tag;
        }

        public static JournalEntry Create(JournalEntryId id, Title? title, Content? content, Tag? tag)
        {
            return new JournalEntry(id, title, content, tag);
        }
        public static JournalEntry CreateNew(Title? title, Content? content, Tag? tag)
        {
            JournalEntry journalEntry = new JournalEntry(JournalEntryId.CreateNew(), title, content, tag);
            journalEntry.AddDomainEvent(new JournalEntryCreatedEvent(journalEntry));
            return journalEntry;
        }


        public void AddAttachment(Attachment attachment)
        {
            _attachments.Add(attachment);
        }
    }
}