using Core.Abstractions;
using Core.Abstractions.Entities;

namespace Core.Aggregates;

public class Member : EntityBase<long>
{
    public string Name { get; private set; }
    
    private Member(long id, string name) : base(id)
    {
        Name = name;
    }

    public static Member Create(long id, string name)
    {
        return new Member(id, name);
    }
}