using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundGroupCutoffs;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FundGroupCutoffServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostCutoffByGroupAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CutoffByFundGroupService.PostCutoffByGroupAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}