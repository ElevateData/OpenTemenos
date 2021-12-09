using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Relationships;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class RelationshipsServiceTests : CredentialManagement
{
    private readonly IPartyClient _client = new PartyClient(HttpClient);
    private const string InternalId = "1";

    [TestMethod, Ignore("POST method")]
    public void PostRelationshipsByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.RelationshipService.PostRelationshipsByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("POST method")]
    public void PostRelationshipsAsync()
    {
        var payload = new _0Payload();
        var result = _client.RelationshipService.PostRelationshipsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutRelationshipsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RelationshipService.PutRelationshipsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteRelationshipsAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.RelationshipService.DeleteRelationshipsAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetRelationshipsByInternalIdAsync()
    {
        var result = _client.RelationshipService.GetRelationshipsByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("PUT method")]
    public void PutRelationshipsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.RelationshipService.PutRelationshipsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod, Ignore("DELETE method")]
    public void DeleteRelationshipsByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.RelationshipService.DeleteRelationshipsByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}