using IssueTracker.DAL.Impl;
using IssueTracker.Entities;
using IssueTracker.Tests.FakeAuth;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace IssueTracker.Tests.Utils
{
    public class IssueTrackerWebFactory : WebApplicationFactory<Program>, IDisposable
    {
        private SqliteConnection _connection;

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.RemoveAll<DbContextOptions<IssueTrackerDbContext>>();

                _connection = new SqliteConnection("Filename=:memory:");
                _connection.Open();
                services.AddDbContextPool<IssueTrackerDbContext>(opt => opt.UseSqlite(_connection));
                services.FillDbTestData();

                services.AddAntiforgery(t =>
                {
                    t.Cookie.Name = AntiForgeryTest.Cookie;
                    t.FormFieldName = AntiForgeryTest.Field;
                });
            });
        }

        public new void Dispose()
        {
            _connection.DisposeAsync();
            base.Dispose();
        }
    }


    internal static class ServiceTestConfigurator
    {
        internal static void FillDbTestData(this IServiceCollection services)
        {
            using (var scope = services.BuildServiceProvider())
            {
                var userManager = scope.GetRequiredService<UserManager<User>>();
                var dbContext = scope.GetRequiredService<IssueTrackerDbContext>();
                dbContext.Database.EnsureCreated();

                var testUser = FakeUser.TestUser;
                var identityResult = userManager.CreateAsync(testUser, FakeUser.GetPasswordHash(testUser)).Result;
                if (!identityResult.Succeeded)
                    throw new Exception("Test user is not created");
            }
        }
    }
}
