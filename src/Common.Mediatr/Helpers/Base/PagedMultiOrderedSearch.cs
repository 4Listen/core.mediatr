using Core.Common.Types;

namespace Common.Mediatr.Helpers.Base
{
    public class PagedMultiOrderedSearch<T> : Request<PagedResult<T>>, ISortedFieldsPagedQuery
    {
        public List<ISortedQuery> FieldsToOrderBy { get; set; }

        public int Page { get; set; }

        public int Results { get; set; }
    }
}
