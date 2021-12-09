using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.FundManagers;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class FundManagersServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundManagersByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundManagerService.PostFundmanagersByParentAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostFundManagersAsync()
    {
        var payload = new _0Payload();
        var result = _client.FundManagerService.PostFundmanagersAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundManagersAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundManagerService.PutFundmanagersAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundManagersAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FundManagerService.DeleteFundmanagersAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetFundManagersByInternalIdAsync()
    {
        var result = _client.FundManagerService
            .GetFundmanagersByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutFundManagersByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundManagerService
            .PutFundmanagersByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteFundManagersByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.FundManagerService
            .DeleteFundmanagersByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}