using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public class Keyword:BaseEntity<int>
    {
        public string Title { get; set; }
    }
}
