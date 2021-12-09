using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.TfAgentLinks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class TfAgentLinksServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTfAgentLinksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService
            .PostTfagentlinksByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTfAgentLinksAsync()
    {
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService.PostTfagentlinksAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTfAgentLinksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TrailerFreeAgentLinkService.PutTfagentlinksAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTfAgentLinksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TrailerFreeAgentLinkService.DeleteTfagentlinksAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTfAgentLinksByInternalIdAsync()
    {
        var result = _client.TrailerFreeAgentLinkService
            .GetTfagentlinksByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTfAgentLinksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService
            .PutTfagentlinksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTfAgentLinksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService
            .DeleteTfagentlinksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}