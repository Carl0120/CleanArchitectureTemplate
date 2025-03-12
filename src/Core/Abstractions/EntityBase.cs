namespace Core.Abstractions;

public abstract class EntityBase<TId>
{
    public TId Id { get; init; }

    protected EntityBase(TId id)
    {
        Id = id;
    }
}
