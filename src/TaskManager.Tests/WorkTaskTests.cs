using System.Net;
using TaskManager.Tests.FakeAuth;
using TaskManager.Tests.Utils;

namespace TaskManager.Tests
{
    public class WorkTaskTests : TestBase
    {
        public WorkTaskTests(TaskManagerWebFactory factory) : base(factory)
        { }

        [Fact]
        public async Task Home_Success()
        {
            //Arrange

            //Act
            var responce = await authHttpClient.GetAsync("/");
            var responseString = await responce.Content.ReadAsStringAsync();

            //Assert
            Assert.Equal(HttpStatusCode.OK, responce.StatusCode);
            Assert.Equal("text/html; charset=utf-8", responce.Content.Headers.ContentType.ToString());
            Assert.Contains($"Welcome {FakeUser.TestUser.DisplayName}", responseString);
        }
    }
}
