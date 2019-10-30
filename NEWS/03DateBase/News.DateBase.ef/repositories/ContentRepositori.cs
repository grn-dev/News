using News.Domain.Contract.DataBase;
using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.repositories
{
    class ContentRepositori:BaseRepositori<Content,int>, IcontentRepositori
    {
        public ContentRepositori(NewsContext ctx):base(ctx)
        {

        }
    }
}
