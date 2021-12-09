using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Product.HoldingLimits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Product;

[TestClass]
public class HoldingLimitsServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostHoldingLimitsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.HoldingLimitService.PostHoldinglimitsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostHoldingLimitsAsync()
    {
        var payload = new _0Payload();
        var result = _client.HoldingLimitService.PostHoldinglimitsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutHoldingLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HoldingLimitService.PutHoldinglimitsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteHoldingLimitsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.HoldingLimitService.DeleteHoldinglimitsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetHoldingLimitsByInternalIdAsync()
    {
        var result = _client.HoldingLimitService.GetHoldinglimitsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutHoldingLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HoldingLimitService.PutHoldinglimitsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteHoldingLimitsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.HoldingLimitService.DeleteHoldinglimitsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}