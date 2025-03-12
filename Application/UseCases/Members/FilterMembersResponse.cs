using Application.Abstractions.FilterResponse;
using Core.Aggregates;

namespace Application.UseCases.Members;

public class FilterMemberResponse : FilterResponse<Member>
{
    private FilterMemberResponse(IEnumerable<Member> objects, FilterMetadata meta) : base(objects, meta)
    {
    }

    public static FilterMemberResponse Create(IEnumerable<Member> objects, FilterMetadata meta)
    {
        return new FilterMemberResponse(objects, meta);
    }
}