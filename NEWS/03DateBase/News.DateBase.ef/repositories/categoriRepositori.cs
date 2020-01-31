using News.Domain.Contract.DataBase;
using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.repositories
{
    public class categoriRepositori : BaseRepositori<Categori>,IcategoriRepositori
    {
        public categoriRepositori(NewsContext ctx) : base(ctx)
        {
            ///_ctx = ctx;
        }

        /*public void Add(Categori categori)
        {
            throw new NotImplementedException();
        }

        public void delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void update(Categori categori)
        {
            throw new NotImplementedException();
        }*/
    }
}
