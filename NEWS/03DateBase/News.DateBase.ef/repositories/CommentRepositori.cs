using News.Domain.Contract.DataBase;
using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.repositories
{
    public class CommentRepositori:BaseRepositori<Comment,int>, ICommentRepositori
    {
        // I dont know
        public CommentRepositori(NewsContext ctx) : base(ctx)
        {

        }

    }
}
