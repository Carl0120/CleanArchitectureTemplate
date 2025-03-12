using MediatR;
using Rop.Result;

namespace Application.Abstractions.QueryAndCommand;

// Para consultas que devuelven un único resultado
public interface IQuery<TResponse> : IRequest<ResultAction<TResponse>> { }


