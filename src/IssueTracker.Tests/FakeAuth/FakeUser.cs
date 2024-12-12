using Microsoft.AspNetCore.Identity;
using TaskManager.Entities;

namespace TaskManager.Tests.FakeAuth
{
    internal static class FakeUser
    {
        internal static User TestUser { get; } = new User()
        {
            Id = 777,
            UserName = "testUser",
            NormalizedUserName = "TESTUSER",
            DisplayName = "Test user",
            SecurityStamp = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            CreatedDateTimeUTC = DateTime.UtcNow,
            UpdatedDateTimeUTC = DateTime.UtcNow,
        };

        internal static string GetPasswordHash(User user)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, "12345");
        }
    }
}
