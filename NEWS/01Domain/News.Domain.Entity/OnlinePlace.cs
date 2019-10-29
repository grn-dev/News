using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public class OnlinePlace:BaseEntity<int>
    {
        public string Title { get; set; }
        public int count { get; set; }
    }
}
