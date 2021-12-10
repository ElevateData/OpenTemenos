using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundValueDates;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FundValueDateServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundValueDateAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundValueDateService.PostFundValueDateAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}