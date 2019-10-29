using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Contract.SearchContext
{
    public class BaseSearchContext
    {
        public int PageSize { get; set; }
        public int PageCount { get; set; }
    }
}
