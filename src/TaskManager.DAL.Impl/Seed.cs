using Bogus;
using Bogus.DataSets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManager.Entities;

namespace TaskManager.DAL.Impl
{
    public static class Seed
    {
        public static void Fill(this ModelBuilder modelBuilder)
        {
            Randomizer.Seed = new Random(123);
            int fakeUsersCount = 7;
            int fakeTasksCount = 77;
            var passwordHasher = new PasswordHasher<User>();

            #region fake users
            var userIds = 1;
            var fakeUserRules = new Faker<User>()
                .RuleFor(u => u.Id, f => userIds++)
                .RuleFor(u => u.UserName, f => f.Internet.UserName(f.Name.FirstName(Name.Gender.Male), f.Name.LastName(Name.Gender.Male)))
                .RuleFor(u => u.NormalizedUserName, (f, u) => u?.UserName?.ToUpper())
                .RuleFor(u => u.DisplayName, f => string.Join(" ", f.Name.FirstName(Name.Gender.Male), f.Name.LastName(Name.Gender.Male)))
                .RuleFor(u => u.CreatedDateTimeUTC, f => DateTime.UtcNow)
                .RuleFor(u => u.UpdatedDateTimeUTC, f => DateTime.UtcNow)
                .RuleFor(u => u.SecurityStamp, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.ConcurrencyStamp, f => Guid.NewGuid().ToString());
            var fakeUsers = fakeUserRules.Generate(fakeUsersCount);
            fakeUsers.ForEach(user => user.PasswordHash = passwordHasher.HashPassword(user, "12345"));
            modelBuilder.Entity<User>().HasData(fakeUsers);
            #endregion
            #region task statuses
            var statuses = new List<WorkTaskStatus>
            {
                new WorkTaskStatus
                {
                    Id = 1,
                    Name = "Создана",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
                new WorkTaskStatus
                {
                    Id = 2,
                    Name = "В работе",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
                new WorkTaskStatus
                {
                    Id = 3,
                    Name = "Пауза",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
                new WorkTaskStatus
                {
                    Id = 4,
                    Name = "Завершена",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
            };
            modelBuilder.Entity<WorkTaskStatus>().HasData(statuses);
            #endregion
            #region  fake tasks
            var taskIds = 1;
            var fakeTaskRules = new Faker<WorkTask>()
                .RuleFor(t => t.Id, f => taskIds++)
                .RuleFor(t => t.Name, f => string.Join(" ", f.Lorem.Words(3)))
                .RuleFor(t => t.Description, f => f.Lorem.Sentences(5))
                .RuleFor(t => t.CreatedDateTimeUTC, f => f.Date.Between(DateTime.UtcNow.AddDays(-7), DateTime.UtcNow))
                .RuleFor(t => t.UpdatedDateTimeUTC, f => f.Date.Between(DateTime.UtcNow.AddDays(-7), DateTime.UtcNow))
                .RuleFor(t => t.ClosedDateTimeUTC, f => f.Date.Between(DateTime.UtcNow.AddDays(-3), DateTime.UtcNow).OrNull(f, (float)0.3))
                .RuleFor(t => t.PlannedDateTimeUTC, f => f.Date.Between(DateTime.UtcNow.AddDays(-3), DateTime.UtcNow).OrNull(f, (float)0.3))
                .RuleFor(t => t.FactedTimeSpan, f => f.Date.Timespan(new TimeSpan(24, 0, 0)).OrNull(f, (float)0.3))
                .RuleFor(t => t.UserId, f => f.Random.Int(1, fakeUsersCount))
                .RuleFor(t => t.StatusId, (f, t) =>
                    t.ClosedDateTimeUTC is not null && t.ClosedDateTimeUTC <= DateTime.UtcNow ? 4 : f.Random.Int(1, 3));
            var fakeTasks = fakeTaskRules.Generate(fakeTasksCount);
            modelBuilder.Entity<WorkTask>().HasData(fakeTasks);
            #endregion


        }
    }
}
