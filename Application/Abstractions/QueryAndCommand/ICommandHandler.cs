using MediatR;
using Rop.Result;

namespace Application.Abstractions.QueryAndCommand;

public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand,ResultAction>
where TCommand : ICommand
{

}
public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand,ResultAction<TResponse>>
    where TCommand : ICommand<TResponse>
{

}
