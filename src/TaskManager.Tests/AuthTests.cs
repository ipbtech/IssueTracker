using Microsoft.Net.Http.Headers;
using System.Net;
using TaskManager.Tests.FakeAuth;
using TaskManager.Tests.Utils;

namespace TaskManager.Tests
{
    public class AuthTests : TestBase
    {
        public AuthTests(TaskManagerWebFactory factory) : base(factory)
        { }

        [Fact]
        public async void Login_POST_Success()
        {
            //Arrange
            var initialRes = await unauthHttpClient.GetAsync("/account/login");
            var antiForgeryVal = await AntiForgeryTest.ExtractAntiForgeryValues(initialRes);

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/account/login");
            postRequest.Headers.Add("Cookie", new CookieHeaderValue(AntiForgeryTest.Cookie, antiForgeryVal.cookie).ToString());

            var formModel = new Dictionary<string, string>
            {
                { AntiForgeryTest.Field, antiForgeryVal.field },
                { "Login", FakeUser.TestUser.UserName },
                { "Password", "12345" },
                { "RememberMe", false.ToString() }
            };
            postRequest.Content = new FormUrlEncodedContent(formModel);

            //Act
            var response = await unauthHttpClient.SendAsync(postRequest);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async void Login_POST_UncorrectPassword()
        {
            //Arrange
            var initialRes = await unauthHttpClient.GetAsync("/account/login");
            var antiForgeryVal = await AntiForgeryTest.ExtractAntiForgeryValues(initialRes);

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/account/login");
            postRequest.Headers.Add("Cookie", new CookieHeaderValue(AntiForgeryTest.Cookie, antiForgeryVal.cookie).ToString());

            var formModel = new Dictionary<string, string>
            {
                { AntiForgeryTest.Field, antiForgeryVal.field },
                { "Login", FakeUser.TestUser.UserName },
                { "Password", "54321" },
                { "RememberMe", false.ToString() }
            };
            postRequest.Content = new FormUrlEncodedContent(formModel);

            //Act
            var response = await unauthHttpClient.SendAsync(postRequest);
            response.Headers.TryGetValues("Set-Cookie", out IEnumerable<string> cookies);
            var responseString = await response.Content.ReadAsStringAsync();

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Contains("Something wrong", responseString);
            Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }


        [Fact]
        public async void Register_POST_Success()
        {
            //Arrange
            var initialRes = await unauthHttpClient.GetAsync("/account/register");
            var antiForgeryVal = await AntiForgeryTest.ExtractAntiForgeryValues(initialRes);

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/account/register");
            postRequest.Headers.Add("Cookie", new CookieHeaderValue(AntiForgeryTest.Cookie, antiForgeryVal.cookie).ToString());

            var formModel = new Dictionary<string, string>
            {
                { AntiForgeryTest.Field, antiForgeryVal.field },
                { "Name", "Somebody" },
                { "Login", "login12345" },
                { "Password", "12345" },
                { "ConfirmPassword", "12345" }
            };
            postRequest.Content = new FormUrlEncodedContent(formModel);

            //Act
            var response = await unauthHttpClient.SendAsync(postRequest);

            //Assert
            Assert.Equal(HttpStatusCode.Found, response.StatusCode);
        }


        [Fact]
        public async void Register_POST_UserAlreadyExist()
        {
            //Arrange
            var initialRes = await unauthHttpClient.GetAsync("/account/register");
            var antiForgeryVal = await AntiForgeryTest.ExtractAntiForgeryValues(initialRes);

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "/account/register");
            postRequest.Headers.Add("Cookie", new CookieHeaderValue(AntiForgeryTest.Cookie, antiForgeryVal.cookie).ToString());

            var formModel = new Dictionary<string, string>
            {
                { AntiForgeryTest.Field, antiForgeryVal.field },
                { "Name", FakeUser.TestUser.DisplayName },
                { "Login", FakeUser.TestUser.UserName },
                { "Password", "12345" },
                { "ConfirmPassword", "12345" }
            };
            postRequest.Content = new FormUrlEncodedContent(formModel);

            //Act
            var response = await unauthHttpClient.SendAsync(postRequest);
            var responseString = await response.Content.ReadAsStringAsync();

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
            Assert.Contains($"DuplicateUserName:Username", responseString);
        }
    }
}
