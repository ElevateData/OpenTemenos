using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AmlBlocks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class AmlBlockServiceTests : CredentialManagement
{
    private const string InternalId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlBlocksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .PostamlblocksByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlBlocksAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .PostamlblocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .PutamlblocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .DeleteamlblocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAmlBlocksByInternalIdAsync()
    {
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .GetamlblocksByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .PutamlblocksByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlockService
            .DeleteamlblocksByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}