using OpenTemenos.FundAdministrations.GlobalInvestor;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Relationships;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
[TestCategory("FundAdministration/GlobalInvestor")]
public class RelationshipServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostRelationshipsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.RelationshipService.PostRelationshipsByParentAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostRelationshipsAsync()
    {
        var payload = new _0Payload();
        var result = _client.RelationshipService.PostRelationshipsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutRelationshipsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RelationshipService.PutRelationshipsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRelationshipsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RelationshipService.DeleteRelationshipsAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetRelationshipsByInternalIdAsync()
    {
        var result = _client.RelationshipService
            .GetRelationshipsByInternalIdAsync(InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutRelationshipsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.RelationshipService
            .PutRelationshipsByIdAsync(internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteRelationshipsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.RelationshipService
            .DeleteRelationshipsByIdAsync(internalId, payload: payload).Result;
        Assert.IsNotNull(result.Body);
    }
}