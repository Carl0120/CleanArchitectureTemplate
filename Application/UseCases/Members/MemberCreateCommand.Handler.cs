using MediatR;
using Rop.Result;

namespace Application.UseCases.Members;

public class MemberCreateCommandHandler : IRequestHandler<MemberCreateCommand,ResultAction<int>>
{
    public async Task<ResultAction<int>> Handle(MemberCreateCommand request, CancellationToken cancellationToken)
    {
        return ResultAction<int>.Success(10);
    }
}
