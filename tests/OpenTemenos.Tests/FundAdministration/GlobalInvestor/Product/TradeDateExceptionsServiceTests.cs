using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.TradeDateExceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class TradeDateExceptionsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void PostTradeDateExceptionsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TradeDateExceptionService.PosttradedateexceptionsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

}