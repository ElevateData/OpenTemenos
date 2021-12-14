using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.HoldingLimits;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class HoldingLimitServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostHoldingLimitsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.HoldingLimitService.PostHoldinglimitsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostHoldingLimitsAsync()
    {
        var payload = new _0Payload();
        var result = _client.HoldingLimitService.PostHoldinglimitsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutHoldingLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HoldingLimitService.PutHoldinglimitsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteHoldingLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HoldingLimitService.DeleteHoldinglimitsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHoldingLimitsByInternalIdAsync()
    {
        var result = _client.HoldingLimitService
            .GetHoldinglimitsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutHoldingLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HoldingLimitService
            .PutHoldinglimitsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteHoldingLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HoldingLimitService
            .DeleteHoldinglimitsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}