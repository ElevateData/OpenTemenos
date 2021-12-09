using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Reference.Cities;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;

//TODO: the documented URL is pointed to localhost:8080. Figure out the correct base url
[TestClass]
public class CitiesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSwapPriceAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.TownService.PostCitiesAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}