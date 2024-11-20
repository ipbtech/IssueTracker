using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Tests.FakeAuth;

namespace TaskManager.Tests.Utils
{
    public abstract class TestBase : IClassFixture<TaskManagerWebFactory>
    {
        protected readonly HttpClient unauthHttpClient;
        protected readonly HttpClient authHttpClient;
        private const string _basePath = "http://localhost:5207";

        public TestBase(TaskManagerWebFactory factory)
        {
            unauthHttpClient = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                BaseAddress = new Uri(_basePath),
                AllowAutoRedirect = false,
            });

            authHttpClient = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication(o =>
                    {
                        o.DefaultAuthenticateScheme = "Test";
                        o.DefaultChallengeScheme = "Test";
                    }).AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("Test", options => { });
                });
            }).CreateClient(new WebApplicationFactoryClientOptions
            {
                BaseAddress = new Uri(_basePath),
                AllowAutoRedirect = false,
            });
        }
    }
}
