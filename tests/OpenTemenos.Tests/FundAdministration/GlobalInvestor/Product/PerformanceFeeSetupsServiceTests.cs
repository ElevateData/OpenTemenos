using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.PerformanceFeeSetups;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class PerformanceFeeServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostPerformanceFeeSetupsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.PerformanceFeeService
            .PostPerformancefeesetupsByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostPerformanceFeeSetupsAsync()
    {
        var payload = new _0Payload();
        var result = _client.PerformanceFeeService.PostPerformancefeesetupsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutPerformanceFeeSetupsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PerformanceFeeService.PutPerformancefeesetupsAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePerformanceFeeSetupsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.PerformanceFeeService
            .DeletePerformancefeesetupsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetPerformanceFeeSetupsByInternalIdAsync()
    {
        var result = _client.PerformanceFeeService
            .GetPerformancefeesetupsByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutPerformanceFeeSetupsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.PerformanceFeeService
            .PutPerformancefeesetupsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeletePerformanceFeeSetupsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.PerformanceFeeService
            .DeletePerformancefeesetupsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}