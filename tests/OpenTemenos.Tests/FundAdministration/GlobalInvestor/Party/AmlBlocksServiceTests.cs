using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.AmlBlocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class AmlBlocksServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "";


    [TestMethod, Ignore("POST method")]
    public void PostAmlBlocksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService.PostamlblocksByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostAmlBlocksAsync()
    {
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService.PostamlblocksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutAmlBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService.PutamlblocksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteAmlBlocksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService.DeleteamlblocksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetAmlBlocksByInternalIdAsync()
    {
        var result = _client.AntiMoneyLaundering.AmlBlocksService.GetamlblocksByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutAmlBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService.PutamlblocksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteAmlBlocksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.AntiMoneyLaundering.AmlBlocksService.DeleteamlblocksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}