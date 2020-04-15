using Magma.DomainModels;
using System.Data.Entity;

namespace Magma.DataAccessLayer
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseConnection")
        {
        }

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AudioBlog>()
                .Property(e => e.Audio_Path)
                .IsUnicode(false);

            modelBuilder.Entity<AudioBlog>()
                .Property(e => e.Audio_Link)
                .IsUnicode(false);

            modelBuilder.Entity<AudioBlog>()
                .Property(e => e.Audio_Thumbail)
                .IsUnicode(false);

            modelBuilder.Entity<BlogCategory>()
                .Property(e => e.Category_Name)
                .IsUnicode(false);

            modelBuilder.Entity<BlogCategory>()
                .Property(e => e.Category_Image)
                .IsUnicode(false);

            modelBuilder.Entity<BlogComment>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<BlogComment>()
                .HasMany(e => e.BlogComments1)
                .WithOptional(e => e.BlogComment1)
                .HasForeignKey(e => e.Parent_Id);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Blog_Title)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Blog_Description)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Blog_CreatedFrom)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Blog_UpdatedFrom)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .Property(e => e.Blog_DeactiveFrom)
                .IsUnicode(false);

            modelBuilder.Entity<Blog>()
                .HasMany(e => e.BlogReactionsMasters)
                .WithRequired(e => e.Blog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BlogType>()
                .Property(e => e.Type_Name)
                .IsUnicode(false);

            modelBuilder.Entity<BlogView>()
                .Property(e => e.View_From)
                .IsUnicode(false);

            modelBuilder.Entity<PictureBlog>()
                .Property(e => e.Blog_ImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.User_Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.User_Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.User_AccountCreatedFrom)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.User_UpdatedFrom)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .Property(e => e.User_DeactiveFrom)
                .IsUnicode(false);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.BlogComments)
                .WithRequired(e => e.UserAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.BlogReactionsMasters)
                .WithRequired(e => e.UserAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.BlogsMasters)
                .WithRequired(e => e.UserAccount)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.UserAccount)
                .HasForeignKey(e => e.User_Id);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.Subscriptions1)
                .WithRequired(e => e.UserAccount1)
                .HasForeignKey(e => e.Author_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserAccount>()
                .HasOptional(e => e.UserDetail)
                .WithRequired(e => e.UserAccount);

            modelBuilder.Entity<UserAccount>()
                .HasMany(e => e.UserLogs)
                .WithRequired(e => e.UserAccount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.User_FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.User_LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.User_Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.User_Gender)
                .IsUnicode(false);

            modelBuilder.Entity<UserDetail>()
                .Property(e => e.User_Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<UserLog>()
                .Property(e => e.User_LoginFrom)
                .IsUnicode(false);

            modelBuilder.Entity<UserRole>()
                .Property(e => e.Role_Name)
                .IsUnicode(false);

            modelBuilder.Entity<VideoBlog>()
                .Property(e => e.Video_Link)
                .IsUnicode(false);

            modelBuilder.Entity<VideoBlog>()
                .Property(e => e.Video_Path)
                .IsUnicode(false);
        }
    }
}
