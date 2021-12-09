using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ExchangeGroups;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class ExchangeGroupsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostExchangeGroupByParentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeGroupService.PostExchangeGroupAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}