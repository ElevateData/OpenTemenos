using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.TfParentSubAgentLinks;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class TfParentSubAgentLinksServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostTfParentSubAgentLinksByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ParentOrSubAgentLinkService
            .PostTfparentsubagentlinksByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostTfParentSubAgentLinksAsync()
    {
        var payload = new _0Payload();
        var result = _client.ParentOrSubAgentLinkService
            .PostTfparentsubagentlinksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTfParentSubAgentLinksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ParentOrSubAgentLinkService
            .PutTfparentsubagentlinksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTfParentSubAgentLinksAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ParentOrSubAgentLinkService
            .DeleteTfparentsubagentlinksAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetTfParentSubAgentLinksByInternalIdAsync()
    {
        var result = _client.ParentOrSubAgentLinkService
            .GetTfparentsubagentlinksByInternalIdAsync(null, null, null, null, null, null, null, null, null, null,
                InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutTfParentSubAgentLinksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ParentOrSubAgentLinkService
            .PutTfparentsubagentlinksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteTfParentSubAgentLinksByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ParentOrSubAgentLinkService
            .DeleteTfparentsubagentlinksByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}