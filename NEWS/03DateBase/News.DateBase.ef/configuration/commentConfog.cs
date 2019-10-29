using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.configuration
{
    class commentConfog: EntityTypeConfiguration<Comment>
    {
        public commentConfog()
        {
            Property(c => c.IP).HasMaxLength(15).IsRequired();
            Property(c => c.Message).HasMaxLength(400).IsRequired().IsUnicode();
            Property(c => c.Title).HasMaxLength(100).IsRequired();
            Property(c => c.name).HasMaxLength(100);
            Property(c => c.Email).HasMaxLength(100);

            HasOptional(c => c.parent).
                WithMany(c => c.childern).
                HasForeignKey(c => c.CommentParentID).
                WillCascadeOnDelete(false);
                
        }
    }
}
