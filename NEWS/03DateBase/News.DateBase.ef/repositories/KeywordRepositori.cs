using News.Domain.Contract.DataBase;
using News.Domain.Contract.SearchContext;
using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.repositories
{
    public class KeywordRepositori : BaseRepositori<Keyword,int>, IkeywordRepositori
    {
        //private readonly NewsContext _ctx;
        //ba public error
        public KeywordRepositori(NewsContext ctx):base(ctx)
        {
            ///_ctx = ctx   
        }
        //public void Add(Keyword keyword)
        //{
        //    _ctx.Keywords.Add(keyword);
        //    _ctx.SaveChanges();
        //}

        //public void delete(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        public SearchResule<Keyword> search(KeywordSearshContext keyword)
        {
            throw new NotImplementedException();
        }

        //public void update(Keyword keyword)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
