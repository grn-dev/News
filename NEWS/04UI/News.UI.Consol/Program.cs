using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.DateBase.ef;
using News.DateBase.ef.repositories;
using News.Domain.Contract.DataBase;

namespace News.UI.Consol
{
    class Program
    {
        static void Main(string[] args)
         {
            using (var ctx = new NewsContext())
            {
                IkeywordRepositori repo = new KeywordRepositori(ctx);

                repo.Add(new Domain.Entity.Keyword
                {
                    Title = "android",
                    insertDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    InserBy = 1,
                    UpdateBy = 1


                });


                /*ctx.Keywords.Add(new Domain.Entity.Keyword {
                    Title = "سبز",
                    insertDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    InserBy = 1,
                    UpdateBy = 1


                });

                ctx.Keywords.Add(new Domain.Entity.Keyword
                {
                    Title = "dev",
                    insertDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    InserBy = 2,
                    UpdateBy = 2


                });*/

                //ctx.SaveChanges();
            }

        }
    }
}
