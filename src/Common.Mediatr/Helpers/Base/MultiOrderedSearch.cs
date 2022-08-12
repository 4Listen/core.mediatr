using Core.Common.Types;

namespace Common.Mediatr.Helpers.Base
{
    public class MultiOrderedSearch<T> : Request<PagedResult<T>>, ISortedFieldsQuery
    {
        public List<ISortedQuery> FieldsToOrderBy { get; set; }
    }
}
