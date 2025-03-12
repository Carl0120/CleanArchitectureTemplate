namespace Core.Abstractions.Entities;

public abstract class EntityBase<TId> : IEntity
{
    public TId Id { get; init; }

    protected EntityBase(TId id)
    {
        Id = id;
    }
}
