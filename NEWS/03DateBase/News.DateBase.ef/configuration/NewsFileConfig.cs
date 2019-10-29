using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.configuration
{
    public class NewsFileConfig: EntityTypeConfiguration<NewsFile>
    {
        public NewsFileConfig()
        {
            Property(c => c.Title).
                HasMaxLength(100).
                IsRequired();

            Property(c => c.description).
                HasMaxLength(100).
                IsRequired();

            Property(c => c.path).
                HasMaxLength(300).
                IsRequired();

            /* 
             1-n
             n-n
             */

            /*HasMany(c => c.cntparnrt).WithMany().Map.();


            HasMany(c => c.cntparnrt).WithOptional();*/


        }
    }
}
