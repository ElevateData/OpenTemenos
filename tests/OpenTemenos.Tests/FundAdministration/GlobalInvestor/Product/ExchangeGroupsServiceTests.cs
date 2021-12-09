using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.ExchangeGroups;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class ExchangeGroupsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void PostExchangeGroupByParentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeGroupService.PostExchangeGroupAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}