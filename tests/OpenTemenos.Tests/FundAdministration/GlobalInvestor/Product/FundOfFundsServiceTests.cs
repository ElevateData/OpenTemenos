using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundOfFunds;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class FundOfFundServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundOfFundsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundOfFundService.PostFundofFundsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundOfFundsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundOfFundService.PostFundofFundsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundOfFundsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundOfFundService.PutFundofFundsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundOfFundsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundOfFundService.DeleteFundofFundsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundOfFundsByInternalIdAsync()
    {
        var result = _client.FundOfFundService
            .GetFundofFundsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundOfFundsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundOfFundService
            .PutFundofFundsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundOfFundsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundOfFundService
            .DeleteFundofFundsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}