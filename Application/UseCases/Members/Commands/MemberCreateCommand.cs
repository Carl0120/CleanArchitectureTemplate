using Application.Abstractions.QueryAndCommand;

namespace Application.UseCases.Members.Commands;

public record MemberCreateCommand(
    string FirstName,
    string LastName,
    string Email) : ICommand<int>;
