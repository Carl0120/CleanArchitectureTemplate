namespace Core.Abstractions;

public abstract class EntityBase<TId>
{
    public TId Id { get; init; }
}
