using CSharpBlog.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CSharpBlog.DAL
{
    public class PostContext : DbContext
    {
        public PostContext() : base("PostContext")
        {

        }

        public DbSet<Post> Posts { get; set; }
        // The following could have been omitted because Post references them
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}