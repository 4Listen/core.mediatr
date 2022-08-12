using Core.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Mediatr.Helpers.Base
{
    public class PagedSearch<T> : Request<PagedResult<T>>, IPagedQuery
    {
        public int Page { get; set; }

        public int Results { get; set; }
    }
}
