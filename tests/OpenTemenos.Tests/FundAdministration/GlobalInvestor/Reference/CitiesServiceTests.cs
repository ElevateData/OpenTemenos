using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Reference.Cities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Reference;
[TestClass]
public class CitiesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void CreateSwapPriceAsync()
    {
        var body = new _0BULKPayload() { };
        var result = _client.TownService.PostCitiesAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}