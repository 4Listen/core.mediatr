using Core.Common.Types;

namespace Common.Mediatr.Helpers.Base
{
    public class OrderedSearch<T> : Request<PagedResult<T>>, ISortedQuery
    {
        public string OrderBy { get; set; }

        public OrderingDirection SortOrder { get; set; }
    }
}
