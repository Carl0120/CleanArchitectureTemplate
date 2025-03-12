using Application.Abstractions;
using Application.Abstractions.QueryAndCommand;

namespace Application.UseCases.Members;

public record MemberByIdQuery(int Id) : IQuery<string>;
