using MediatR;
using Rop.Result;

namespace Application.Abstractions.QueryAndCommand;

public interface ICommand : IRequest<ResultAction>
{

}
public interface ICommand<TResponse> : IRequest<ResultAction<TResponse>>
{

}
