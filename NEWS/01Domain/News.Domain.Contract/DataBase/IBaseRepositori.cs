using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Contract.DataBase
{
    public interface IBaseRepositori<TEntity,Tkey> where TEntity : new()
    {
        //T:new باید کانسترکنور دیفالت بدون پرامتر
        // چون اگه constractor بدون پلراکتر داشته باشه
        //
        void Add(TEntity entity);
        void update(TEntity entity);//bool
        void delete(Tkey entity);// becayse all id has id if dontkhow maybe id defining generic
    
    }
}
