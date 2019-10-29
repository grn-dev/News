using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.configuration
{
    public class OnlinePlaceConfig: EntityTypeConfiguration<OnlinePlace>
    {
        public OnlinePlaceConfig()
        {
            Property(c => c.Title).
                HasMaxLength(100).
                IsRequired();
        }
    }
}
