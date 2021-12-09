using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.Profiles;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ProfileServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient);

    [TestMethod]
    [Ignore("POST method")]
    public void PostProfilesByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ProfileService.PostProfilesByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostProfilesAsync()
    {
        var payload = new _0Payload();
        var result = _client.ProfileService.PostProfilesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutProfilesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ProfileService.PutProfilesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteProfilesAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ProfileService.DeleteProfilesAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetProfilesByInternalIdAsync()
    {
        var result = _client.ProfileService
            .GetProfilesByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutProfilesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ProfileService.PutProfilesByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteProfilesByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ProfileService.DeleteProfilesByIdAsync(null, null, null, null, null, internalId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}