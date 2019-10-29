using News.Domain.Contract.SearchContext;
using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Contract.DataBase
{
    public interface IkeywordRepositori:IBaseRepositori<Keyword>
    {
    //    void Add(Keyword keyword);
    //    void update(Keyword keyword);//bool
    //    void delete(int Id);
        SearchResule<Keyword> search(KeywordSearshContext keyword);

    }


}
