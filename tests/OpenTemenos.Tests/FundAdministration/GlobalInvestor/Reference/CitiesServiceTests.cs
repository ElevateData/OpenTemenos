using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Reference.Cities;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

//TODO: the documented URL is pointed to localhost:8080. Figure out the correct base url
[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class CityServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSwapPriceAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.TownService.PostCitiesAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}