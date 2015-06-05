using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyBlog.DAL
{
    public class PostsContext : DbContext
    {
            public PostsContext() : base("PostsDB") { }

            public DbSet<Posts> post { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
     }
}
