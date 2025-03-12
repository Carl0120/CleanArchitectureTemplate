using MediatR;
using Rop.Result;

namespace Application.Abstractions.QueryAndCommand;

/// <summary TResponse="(resultado único)">
/// Handler para IQuery
/// </summary>
/// <typeparam name="TQuery"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public interface IQueryHandler<in TQuery, TResponse>
    : IRequestHandler<TQuery, ResultAction<TResponse>>
    where TQuery : IQuery<TResponse>
{
}

