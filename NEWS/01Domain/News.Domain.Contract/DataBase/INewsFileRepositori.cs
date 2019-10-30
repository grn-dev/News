using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Contract.DataBase
{
    public interface INewsFileRepositori:IBaseRepositori<NewsFile,int>
    {
        //TODO only Content
    }
}
