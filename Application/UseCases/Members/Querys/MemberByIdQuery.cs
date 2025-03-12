using Application.Abstractions.QueryAndCommand;

namespace Application.UseCases.Members.Querys;

public record MemberByIdQuery(int Id) : IQuery<string>;
