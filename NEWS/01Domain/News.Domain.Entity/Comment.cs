using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public class Comment:BaseEntity<int>
    {
        public string Message { get; set; }
        public string Title { get; set; }
        public enmCommebtStatuse status { get; set; }


        public int ContentID { get; set; }
        public Content content { get; set; }

        public string name { get; set; }
        public string Email { get; set; }
        public string IP { get; set; }

        public int MyProperty { get; set; }
        
        public int? CommentParentID { get; set; }
        public List<Comment> childern { get; set; }
        public Comment parent { get; set; }


    }
    
}
