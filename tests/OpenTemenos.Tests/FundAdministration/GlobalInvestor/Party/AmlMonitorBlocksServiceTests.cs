using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlMonitorBlocks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class AmlMonitorBlockServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlMonitorBlocksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .PostAmlmonitorBlocksByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlMonitorBlocksAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .PostAmlmonitorBlocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlMonitorBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .PutAmlmonitorBlocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlMonitorBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .DeleteAmlmonitorBlocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAmlMonitorBlocksByInternalIdAsync()
    {
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .GetAmlmonitorBlocksByInternalIdAsync(
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlMonitorBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .PutAmlmonitorBlocksByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlMonitorBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlockService
            .DeleteAmlmonitorBlocksByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}