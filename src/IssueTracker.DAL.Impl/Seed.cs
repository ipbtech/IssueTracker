using Bogus;
using Bogus.DataSets;
using IssueTracker.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.DAL.Impl
{
    public static class Seed
    {
        public static void Fill(this ModelBuilder modelBuilder)
        {
            Randomizer.Seed = new Random(123);
            int fakeUsersCount = 7;
            int fakeIssuesCount = 77;
            int fakeCommentsCount = 88;
            var passwordHasher = new PasswordHasher<User>();

            #region fake users
            var userIdsIncrement = 1;
            var fakeUserRules = new Faker<User>()
                .RuleFor(u => u.Id, f => userIdsIncrement++)
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
            var statuses = new List<Status>
            {
                new Status
                {
                    Id = 1,
                    Name = "Created",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
                new Status
                {
                    Id = 2,
                    Name = "In progress",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
                new Status
                {
                    Id = 3,
                    Name = "Pause",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
                new Status
                {
                    Id = 4,
                    Name = "Done",
                    CreatedDateTimeUTC = DateTime.UtcNow,
                    UpdatedDateTimeUTC = DateTime.UtcNow,
                },
            };
            modelBuilder.Entity<Status>().HasData(statuses);
            #endregion
            #region  fake tasks
            var issueIdsIncrement = 1;
            var fakeIssueRules = new Faker<Issue>()
                .RuleFor(t => t.Id, f => issueIdsIncrement++)
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
            var fakeIssues = fakeIssueRules.Generate(fakeIssuesCount);
            modelBuilder.Entity<Issue>().HasData(fakeIssues);
            #endregion
            #region fake comments
            var commentIdsIncrement = 1;
            var fakeCommentRules = new Faker<Comment>()
                .RuleFor(t => t.Id, f => commentIdsIncrement++)
                .RuleFor(t => t.Content, f => f.Lorem.Sentences(5))
                .RuleFor(t => t.CreatedDateTimeUTC, f => f.Date.Between(DateTime.UtcNow.AddDays(-6), DateTime.UtcNow))
                .RuleFor(t => t.UpdatedDateTimeUTC, f => f.Date.Between(DateTime.UtcNow.AddDays(-6), DateTime.UtcNow))
                .RuleFor(t => t.UserId, f => f.Random.Int(1, fakeUsersCount))
                .RuleFor(t => t.IssueId, f => f.Random.Int(1, fakeIssuesCount));
            var fakeComments = fakeCommentRules.Generate(fakeCommentsCount);
            modelBuilder.Entity<Comment>().HasData(fakeComments);
            #endregion
        }
    }
}
