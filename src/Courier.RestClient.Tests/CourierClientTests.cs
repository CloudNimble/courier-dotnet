using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clearbit.RestClient.Tests
{
    [TestClass]
    public class CourierClientTests
    {

        #region Private Members

        private IConfiguration Configuration { get; set; }

        #endregion

        #region Constructors

        public CourierClientTests()
        {
            // the type specified here is just so the secrets library can 
            // find the UserSecretId we added in the csproj file
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<CourierClientTests>();

            Configuration = builder.Build();
        }

        #endregion

        [TestMethod]
        public void BuildRequestQueryString_UsesCorrectNames()
        {
            //var client = new ClearbitClient(Configuration["ClearbitApiKey"]);
            //var enrichmentRequest = new EnrichmentCompanyRequest("nimbleapps.cloud")
            //{
            //    CompanyName = "CloudNimble"
            //};
            //var request = new RestRequest("");
            //client.BuildRequestQueryString(request, enrichmentRequest, new string[] { });

            //var prop = typeof(RestRequest).GetProperty("UrlSegments", BindingFlags.NonPublic | BindingFlags.Instance);
            //var getter = prop.GetGetMethod(nonPublic: true);
            //var parameters = (IList)getter.Invoke(request, null);
            //parameters.Should().HaveCount(2);

            //var one = ToDynamic(parameters[1]);
            //((string)one.Key).Should().Be("domain");

        }

    }

}