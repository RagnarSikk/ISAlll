namespace isa3.Domain.Repos
{
    public interface IPaging
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        bool HasNextPage { get; set; }
        bool HasPreviousPage { get; set; }
    }
}