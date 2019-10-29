using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public class Content:BaseEntity<int>
    {
        public EnuContentType Contentype { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public DateTime? DatePublish { get; set; }
        public int DefaultImageID { get; set; }
        public NewsFile DefaulImage { get; set; }
        public int DefaulcategoriID { get; set; }
        public Categori Defaulcategori { get; set; }
        public List<NewsFile> RelatedNewsFiles { get; set; }
        public List<Categori> RelatedCategoris { get; set; }
        public List<Keyword> keyword { get; set; }
        public int? parentID { get; set; }
        public List<Content> RelatedContents { get; set; }
        public List<OnlinePlace> OnlinePlaces { get; set; }
        public List<Comment> comments { get; set; }



    }
}
