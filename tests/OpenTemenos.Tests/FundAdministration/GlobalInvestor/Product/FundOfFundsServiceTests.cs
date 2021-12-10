using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundOfFunds;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundOfFundsServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundOfFundsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundOfFundService.PostFundofFundsByParentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundOfFundsAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundOfFundService.PostFundofFundsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundOfFundsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundOfFundService.PutFundofFundsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundOfFundsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundOfFundService.DeleteFundofFundsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundOfFundsByInternalIdAsync()
    {
        var result = _client.FundOfFundService
            .GetFundofFundsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
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
            .PutFundofFundsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundOfFundsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundOfFundService
            .DeleteFundofFundsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}