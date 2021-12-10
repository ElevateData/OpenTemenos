using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundValueDates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundValueDatesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundValueDateAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundValueDateService.PostFundValueDateAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}