using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace IntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var factory = new WebApplicationFactory<Program>();
            var option = factory.Services.GetRequiredService<IOptions<AppEnv>>();
            var appEnv = option.Value;

            Assert.Equal("MyApp", appEnv.ApplicationName);
        }
    }
}