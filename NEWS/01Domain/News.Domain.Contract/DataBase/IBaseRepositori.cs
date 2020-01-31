using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Contract.DataBase
{
    public interface IBaseRepositori<T> where T : new()
    {
        //T:new باید کانسترکنور دیفالت بدون پرامتر
        // چون اگه constractor بدون پلراکتر داشته باشه
        //
        void Add(T entity);
        void update(T entity);//bool
        void delete(int entity);// becayse all id has id if dontkhow maybe id defining generic
        List<T> GetAll();//TEntity

    }
}
