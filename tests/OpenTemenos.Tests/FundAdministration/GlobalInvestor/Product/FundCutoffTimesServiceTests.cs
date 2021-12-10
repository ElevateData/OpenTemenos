using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundCutoffTimes;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundCutoffTimesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundCutOffTimeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundCutoffTimeService.PostFundCutOffTimeAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}