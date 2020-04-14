using Magma.DomainModels;
using System.Data.Entity;

namespace Magma.DataAccessLayer
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext() : base("DatabaseConnection") { }
        public virtual DbSet<AudioBlog> AudioBlogs { get; set; }
        public virtual DbSet<BlogCategory> BlogCategories { get; set; }
        public virtual DbSet<BlogComment> BlogComments { get; set; }
        public virtual DbSet<BlogReactionsMaster> BlogReactionsMasters { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogsMaster> BlogsMasters { get; set; }
        public virtual DbSet<BlogType> BlogTypes { get; set; }
        public virtual DbSet<BlogView> BlogViews { get; set; }
        public virtual DbSet<PictureBlog> PictureBlogs { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserLog> UserLogs { get; set; }
        public virtual DbSet<UserRoleMaster> UserRoleMasters { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<VideoBlog> VideoBlogs { get; set; }
    }
}
