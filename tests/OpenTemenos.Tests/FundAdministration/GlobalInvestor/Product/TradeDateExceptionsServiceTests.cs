using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TradeDateExceptions;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class TradeDateExceptionServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTradeDateExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TradeDateExceptionService
            .PosttradedateexceptionsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}