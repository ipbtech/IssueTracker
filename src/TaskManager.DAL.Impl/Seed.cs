using Bogus;
using Bogus.DataSets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManager.Entities;

namespace TaskManager.DAL.Impl
{
    public static class Seed
    {
        private static Random _bogusRandom = new Random(123);
        public static void FillDbTestData(this ModelBuilder modelBuilder)
        {
            Randomizer.Seed = new Random(123);
            var passwordHasher = new PasswordHasher<User>();

            #region fake users
            var userIds = 1;
            var fakeUserRules = new Faker<User>().StrictMode(true)
                .RuleFor(u => u.Id, f => userIds++)
                .RuleFor(u => u.UserName, f => f.Internet.UserName(f.Name.FirstName(Name.Gender.Male), f.Name.LastName(Name.Gender.Male)))
                .RuleFor(u => u.NormalizedUserName, (f, u) => u?.UserName?.ToUpper())
                .RuleFor(u => u.DisplayName, f => string.Join(" ", f.Name.FirstName(Name.Gender.Male), f.Name.LastName(Name.Gender.Male)))
                .RuleFor(u => u.CreatedDateTimeUTC, f => DateTime.UtcNow)
                .RuleFor(u => u.UpdatedDateTimeUTC, f => DateTime.UtcNow)
                .RuleFor(u => u.SecurityStamp, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.ConcurrencyStamp, f => Guid.NewGuid().ToString());
            var fakeUsers = fakeUserRules.Generate(7);
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



        }


        private static IEnumerable<User> GenerateFakeUsers()
        {
            
            
            
            return new List<User>();
        }
    }
}
