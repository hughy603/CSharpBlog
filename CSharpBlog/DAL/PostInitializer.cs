using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CSharpBlog.Models;

namespace CSharpBlog.DAL
{
    public class PostInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PostContext>
    {
        protected override void Seed(PostContext context)
        {
            var posts = new List<Post>
            {
                new Post { Title="Hello World", PostedOn=DateTime.Now },
            };
            posts.ForEach(s => context.Posts.Add(s));

            context.SaveChanges();
        }
    }
}