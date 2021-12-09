using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundValueDates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundValueDatesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void PostFundValueDateAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundValueDateService.PostFundValueDateAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

}