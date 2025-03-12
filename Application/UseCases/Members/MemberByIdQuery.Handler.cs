using Application.Abstractions;
using Application.Abstractions.QueryAndCommand;
using Rop.Result;

namespace Application.UseCases.Members;

public class MemberMyIdQueryHandler :IQueryHandler<MemberByIdQuery,string>
{
    public Task<ResultAction<string>> Handle(MemberByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
