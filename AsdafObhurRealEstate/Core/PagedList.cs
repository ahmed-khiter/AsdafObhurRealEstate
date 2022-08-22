using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Core
{
    /// <summary>
    /// Paged list
    /// </summary>
    /// <typeparam name="T">T</typeparam>
    [Serializable]
    public class PagedList<T> : List<T>
    {


        public PagedList(IEnumerable<T> items, int total, int pageIndex, int pageSize, bool getOnlyTotalCount = false)
    {

        TotalCount = total;
        TotalPages = total / pageSize;

        if (total % pageSize > 0)
            TotalPages++;

        PageSize = pageSize;
        PageIndex = pageIndex;

        if (getOnlyTotalCount)
            return;

        AddRange(items);
    }

    public static async Task<PagedList<T>> CreateAsync(IQueryable<T> source,
        int pageNumber, int pageSize)
    {
        var count = await source.CountAsync();
        var items = await source.Skip((pageNumber) * pageSize).Take(pageSize).ToListAsync();
        return new PagedList<T>(items, count, pageNumber, pageSize);
    }



    /// <summary>
    /// Page index
    /// </summary>
    public int PageIndex { get; }

    /// <summary>
    /// Page size
    /// </summary>
    public int PageSize { get; }

    /// <summary>
    /// Total count
    /// </summary>
    public int TotalCount { get; }

    /// <summary>
    /// Total pages
    /// </summary>
    public int TotalPages { get; }

    /// <summary>
    /// Has previous page
    /// </summary>
    //public bool HasPreviousPage => PageIndex > 0;

    /// <summary>
    /// Has next page
    /// </summary>
    //public bool HasNextPage => PageIndex + 1 < TotalPages;
}
}