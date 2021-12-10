using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AmlBlocks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AmlBlocksServiceTests : CredentialManagement
{
    private const string InternalId = "";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlBlocksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService
            .PostamlblocksByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostAmlBlocksAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService
            .PostamlblocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutAmlBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService
            .PutamlblocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService
            .DeleteamlblocksAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAmlBlocksByInternalIdAsync()
    {
        var result = _client.AntiMoneyLaundering.AmlBlocksService
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
        var result = _client.AntiMoneyLaundering.AmlBlocksService
            .PutamlblocksByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteAmlBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService
            .DeleteamlblocksByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}