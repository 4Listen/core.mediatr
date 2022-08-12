using Core.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Mediatr.Helpers.Base
{
    public class PagedOrderedSearch<T> : Request<PagedResult<T>>, ISortedPagedQuery
    {
        public string OrderBy { get; set; }

        public OrderingDirection SortOrder { get; set; }

        public int Page { get; set; }

        public int Results { get; set; }
    }
}
