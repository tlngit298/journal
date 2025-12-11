using JournalApp.Domain.Common;

namespace JournalApp.Domain.Aggregates.JournalEntry
{
    public class Attachment : Entity<Guid>
    {
        public string FileName { get; private set; }
        public string FileType { get; private set; }

        public Attachment(Guid id, string fileName, string fileType) : base(id)
        {
            FileName = fileName;
            FileType = fileType;
        }
    }
}