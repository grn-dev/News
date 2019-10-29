using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef.configuration
{
    public class contentConfig: EntityTypeConfiguration<Content>
    {
        public contentConfig()
        {
            /* n-n */
            HasMany(c=> c.keyword).
                WithMany().
                Map(c =>
                    c.ToTable("Contentkeywords")
                    .MapLeftKey("contentid")
                    .MapRightKey("keywordid"));

            HasMany(c => c.RelatedCategoris).
                WithMany().
                Map(c => c.ToTable("ContentRelatedCategoris")
                .MapLeftKey("ContentID")
                .MapRightKey("RelatedCategoriId"));

            /*HasMany(c => c.comments).
                WithMany().
                Map(c => c.ToTable("ContentComment")
                .MapLeftKey("ContentID")
                .MapRightKey("CommentId"));*/

            HasMany(c => c.OnlinePlaces).
                WithMany().
                Map(c => c.ToTable("ContentOnlinePlaces")
                .MapLeftKey("ContentID")
                .MapRightKey("OnlinePlaceID"));

            HasMany(c => c.RelatedNewsFiles).
                WithMany().
                Map(c => c.ToTable("ContentRelatedNewsFiles")
                .MapLeftKey("ContentID")
                .MapRightKey("FileId"));
            /*  n-1  */

            HasMany(c => c.RelatedContents)
                .WithOptional()
                .HasForeignKey(c => c.parentID).WillCascadeOnDelete(false);

            /*1-1 hatmi*/ 
            HasRequired(c => c.Defaulcategori).
                WithMany().
                HasForeignKey(c => c.DefaulcategoriID).WillCascadeOnDelete(false);

            HasRequired(c => c.DefaulImage).
                WithMany().
                HasForeignKey(c => c.DefaultImageID).WillCascadeOnDelete(false);
            /* 0-n */
            HasMany(c => c.comments).
                WithRequired(c => c.content).
                HasForeignKey(c => c.ContentID).WillCascadeOnDelete(false);
            //Added By Grn
            Property(C => C.ShortDescription).
                HasMaxLength(500).
                IsRequired();

            /*Property(C => C.Body).
                HasMaxLength(4000).// 
                //IsRequired(). galeri image
                IsUnicode();*/

            Property(C => C.Title).
                HasMaxLength(100).
                IsRequired();


        }
    }
}
