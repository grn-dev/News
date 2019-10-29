using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public class NewsFile:BaseEntity<int>
    {
        public string Title { get; set; }
        public string description { get; set; }
        public EnmTypeFile typefile { get; set; }
        public string path { get; set; }
        public int DownlaodCount { get; set; }
        public int FileSize { get; set; }
        /*public  List<Content> cntparnrt { get; set; }
        public int cntparentId { get; set; }*/

    }
}
