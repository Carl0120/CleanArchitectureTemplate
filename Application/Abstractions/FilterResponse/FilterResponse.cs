namespace Application.Abstractions.FilterResponse;

public abstract class FilterResponse<T> where T : class
{
    public IEnumerable<T> Objects { get; private set; }
    
    public FilterMetadata Meta { get;  private set; }

    protected FilterResponse(IEnumerable<T> objects, FilterMetadata meta)
    {
        Meta = meta;
        Objects = objects;
    }
}

public class FilterMetadata
{
    public int CurrentPage { get; private set; }
    public int? NextPage { get; private set; }
    public int? PrevPage { get; private set; }
    public int TotalPage { get; private set; }
    public int TotalCount { get; private set; }
   
    public FilterMetadata(int page, int per, int count)
    {
        NextPage = null;
        PrevPage = null;
        TotalCount = count;
        CurrentPage = page;
        TotalPage = count / per;

        if (CurrentPage <= 0 && count >= 1)
        {
            CurrentPage = 1;
            TotalPage = 1;
            return;
        }

        if (count % per > 0)
            TotalPage++;

        if (TotalPage > CurrentPage)
            NextPage = CurrentPage + 1;
        if (CurrentPage > 1)
            PrevPage = CurrentPage - 1;
    }
    
    public FilterMetadata()
    {
        CurrentPage = 1;
        TotalPage = 1;
    }

    public FilterMetadata(int totalCount)
        : this()
    {
        TotalCount = totalCount;
    }
}