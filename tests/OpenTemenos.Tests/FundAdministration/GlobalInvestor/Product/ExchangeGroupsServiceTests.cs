using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ExchangeGroups;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class ExchangeGroupServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostExchangeGroupByParentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeGroupService.PostExchangeGroupAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}