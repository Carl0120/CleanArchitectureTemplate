namespace Core.Abstractions.Infrastructure;

public interface IRepositoryBase
{
    public Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
