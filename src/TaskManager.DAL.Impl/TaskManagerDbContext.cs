using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TaskManager.Entities;

namespace TaskManager.DAL.Impl
{
    public class TaskManagerDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<WorkTask> Tasks { get; set; }
        public DbSet<WorkTaskStatus> Statuses { get; set; }
        public DbSet<WorkTaskComment> Comments { get; set; }

        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options)
        {
            if (!Database.CanConnect())
                throw new Exception("Couldn't connect to the database");

            if (Database.GetPendingMigrations().Any())
                Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().Property(user => user.DisplayName).HasMaxLength(150).IsRequired();
            builder.Entity<WorkTaskStatus>().Property(user => user.Name).HasMaxLength(150).IsRequired();
            builder.Entity<WorkTask>().Property(user => user.Name).HasMaxLength(150).IsRequired();

            builder.Entity<WorkTask>().HasOne(prop => prop.User).WithMany(prop => prop.Tasks)
                .HasPrincipalKey(user => user.Id).HasForeignKey(task => task.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<WorkTask>().HasOne(prop => prop.Status).WithMany(prop => prop.Tasks)
                .HasPrincipalKey(user => user.Id).HasForeignKey(task => task.StatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WorkTaskComment>().HasOne(prop => prop.Task).WithMany(prop => prop.Comments)
                .HasPrincipalKey(task => task.Id).HasForeignKey(com => com.TaskId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<WorkTaskComment>().HasOne(prop => prop.User).WithMany(prop => prop.Comments)
                .HasPrincipalKey(user => user.Id).HasForeignKey(com => com.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            Seed.Fill(builder);
        }
    }
}
