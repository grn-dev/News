using News.Domain.Contract.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.repositories
{
    public class BaseRepositori<T>: IBaseRepositori<T> where T : class,new()//what
    {
        protected readonly NewsContext _ctx;//what is not private
        public BaseRepositori(NewsContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);

            /*
            without class  => where T : class,new()
            _ctx.Set(entity.GetType()).Add(entity);
             */
            _ctx.SaveChanges();
        }

        public void delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            //throw new NotImplementedException();
            return _ctx.Set<T>().ToList();
                //Keywords.ToList();

        }

        public void update(T entity)
        {
            throw new NotImplementedException();
            
        }
    }
}
