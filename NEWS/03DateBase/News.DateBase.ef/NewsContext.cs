using News.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.DateBase.ef
{
    public class NewsContext:DbContext
    {
        public NewsContext():base("cnn")
        {

        }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Categori> Categoris { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NewsFile> NewsFiles { get; set; }
        public DbSet<OnlinePlace> OnlinePlaces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
