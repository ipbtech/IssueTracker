using IssueTracker.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.DAL.Impl
{
    public class IssueTrackerDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public IssueTrackerDbContext(DbContextOptions<IssueTrackerDbContext> options) : base(options)
        {
            if (!Database.CanConnect())
                throw new Exception("Couldn't connect to the database");

            var connStr = Database.GetConnectionString();
            if (connStr != "Filename=:memory:" && Database.GetPendingMigrations().Any())
                Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().Property(user => user.DisplayName).HasMaxLength(150).IsRequired();
            builder.Entity<Status>().Property(user => user.Name).HasMaxLength(150).IsRequired();
            builder.Entity<Issue>().Property(user => user.Name).HasMaxLength(150).IsRequired();
            builder.Entity<Issue>().Property(user => user.Description).HasMaxLength(255);

            builder.Entity<Issue>().HasOne(prop => prop.User).WithMany(prop => prop.Issues)
                .HasPrincipalKey(user => user.Id).HasForeignKey(task => task.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Issue>().HasOne(prop => prop.Status).WithMany(prop => prop.Issues)
                .HasPrincipalKey(user => user.Id).HasForeignKey(task => task.StatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Comment>().HasOne(prop => prop.Issue).WithMany(prop => prop.Comments)
                .HasPrincipalKey(task => task.Id).HasForeignKey(com => com.IssueId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Comment>().HasOne(prop => prop.User).WithMany(prop => prop.Comments)
                .HasPrincipalKey(user => user.Id).HasForeignKey(com => com.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            Seed.Fill(builder);
        }
    }
}
