using Core.Common.Types;

namespace Common.Mediatr.Helpers.Base
{
	public class Search<T> : Request<PagedResult<T>>, ISortedPagedQuery
	{
		public string OrderBy { get; set; }

		public OrderingDirection SortOrder { get; set; }

        public int Page { get; set; }	

        public int Results { get; set; }
	}
}
