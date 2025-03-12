using Application.Abstractions;
using Application.Abstractions.QueryAndCommand;
using MediatR;
using Rop.Result;

namespace Application.UseCases.Members;

public record MemberCreateCommand(
    string FirstName,
    string LastName,
    string Email) : ICommand<int>;
