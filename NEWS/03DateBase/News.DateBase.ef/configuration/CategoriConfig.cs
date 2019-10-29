using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.configuration
{
    public class CategoriConfig: EntityTypeConfiguration<Categori>
    {
        public CategoriConfig()
        {

            Property(c => c.Title).
                IsRequired().
                HasMaxLength(100).
                IsUnicode();

            HasOptional(c => c.Parent).WithMany(c => c.Childeren).
                HasForeignKey(c => c.parentId).WillCascadeOnDelete(false);

            
        }
    }
}
