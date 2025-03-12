using Application.Abstractions.FilterResponse;
using Application.Abstractions.QueryAndCommand;
using Core.Aggregates;
using Rop.Result;

namespace Application.UseCases.Members.Querys;

public class FilterMemberQueryHandler : IQueryHandler<FilterMemberQuery, FilterMemberResponse>
{
    public async Task<ResultAction<FilterMemberResponse>> Handle(FilterMemberQuery request, CancellationToken cancellationToken)
    {
        var filter = FilterMemberResponse.Create(new List<Member>(), new FilterMetadata());
        return ResultAction<FilterMemberResponse>.Success(filter);
    }
}