using JournalApp.Domain.Common.Interfaces;

namespace JournalApp.Domain.Common
{
    public abstract class Entity<TId> : IEquatable<TId>, IHasDomainEvents where TId : notnull
    {
        public TId Id { get; protected init; } = default!;
        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
        protected Entity(TId id)
        {
            Id = id;
        }
        public Entity()
        {
            
        }
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        // public override bool Equals(object? obj)
        // {
        //     return obj is Entity<TId> entity && Id.Equals(entity.Id);
        // }

        public bool Equals(TId? other)
        {
            return Equals((object?)other);
        }

        // public static bool operator ==(Entity<TId>? left, Entity<TId>? right)
        // {
        //     return Equals(left, right);
        // }

        // public static bool operator !=(Entity<TId>? left, Entity<TId>? right)
        // {
        //     return !Equals(left, right);
        // }

        // public override int GetHashCode()
        // {
        //     return Id.GetHashCode();
        // }
    }
}