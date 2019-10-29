using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.configuration
{
    public class Keywordconfig:EntityTypeConfiguration<Keyword>
    {
        public Keywordconfig()
        {
            Property(c => c.Title).
                IsRequired().
                HasMaxLength(100).
                IsUnicode();
        }
    }
}
