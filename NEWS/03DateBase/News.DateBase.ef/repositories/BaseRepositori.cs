using News.Domain.Contract.DataBase;
using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.repositories
{
    public class BaseRepositori<TEntity,Tkey>: IBaseRepositori<TEntity,Tkey> 
        where TEntity : BaseEntity<Tkey>,new()//what
    {
        protected readonly NewsContext _ctx;//what is not private
        public BaseRepositori(NewsContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TEntity entity)
        {
            
            _ctx.Set<TEntity>().Add(entity);

            /*
            without class  => where T : class,new()
            _ctx.Set(entity.GetType()).Add(entity);
             */
            _ctx.SaveChanges();
        }

        



        public void delete(Tkey entity)
        {
            throw new NotImplementedException();
            //TODO
            /**/
            //_ctx.Set<TEntity>().Add(entity);
            _ctx.
                
                Set<TEntity>().Remove().ID




        }

        

        public void update(TEntity entity)
        {
            throw new NotImplementedException();
            //TODO
        }
    }
}
