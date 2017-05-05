using McocBlog.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace McocBlog.Data
{
   public class McocBlogContext : IdentityDbContext<ApplicationUser>
    {

        public McocBlogContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static McocBlogContext Create()
        {
            return new McocBlogContext();
        }
       
        public DbSet<Post> Posts { get; set; }

        public System.Data.Entity.DbSet<McocBlog.Models.EntityModels.Champion> Champions { get; set; }
    }
}