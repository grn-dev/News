using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public class Categori:BaseEntity<int>
    {
        public string Title { get; set; }
        public int? parentId { get; set; }
        public Categori Parent { get; set; }
        public List<Categori> Childeren { get; set; }


        //30:24
    }
}
