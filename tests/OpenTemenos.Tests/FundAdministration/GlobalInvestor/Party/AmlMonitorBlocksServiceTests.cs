using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AmlMonitorBlocks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AmlMonitorBlocksServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlMonitorBlocksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .PostAmlmonitorBlocksByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlMonitorBlocksAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .PostAmlmonitorBlocksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlMonitorBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .PutAmlmonitorBlocksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlMonitorBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .DeleteAmlmonitorBlocksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAmlMonitorBlocksByInternalIdAsync()
    {
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .GetAmlmonitorBlocksByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlMonitorBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .PutAmlmonitorBlocksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlMonitorBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlMonitorBlocksService
            .DeleteAmlmonitorBlocksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}