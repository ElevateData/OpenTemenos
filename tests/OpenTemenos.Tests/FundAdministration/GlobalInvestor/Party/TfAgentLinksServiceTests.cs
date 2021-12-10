using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.TfAgentLinks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass, TestCategory("FundAdministration/GlobalInvestor")]
public class TfAgentLinkServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostTfAgentLinksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService
            .PostTfagentlinksByParentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTfAgentLinksAsync()
    {
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService.PostTfagentlinksAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTfAgentLinksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TrailerFreeAgentLinkService.PutTfagentlinksAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTfAgentLinksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.TrailerFreeAgentLinkService.DeleteTfagentlinksAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTfAgentLinksByInternalIdAsync()
    {
        var result = _client.TrailerFreeAgentLinkService
            .GetTfagentlinksByInternalIdAsync(InternalId)
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
            .PutTfagentlinksByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTfAgentLinksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.TrailerFreeAgentLinkService
            .DeleteTfagentlinksByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}