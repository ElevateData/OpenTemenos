using FundAdministration.GlobalInvestor;
using FundAdministration.GlobalInvestor.Party.ProfileSecurity;

namespace OpenTemenos.Tests.FundAdministration.GlobalInvestor.Party;

[TestClass]
public class ProfileSecurityServiceTests : CredentialManagement
{
    private const string InternalId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void PostProfileSecurityByParentAsync()
    {
        var payload = new _0Payload();
        var result = _client.ProfileSecurityService
            .PostProfilesecurityByParentAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("POST method")]
    public void PostProfileSecurityAsync()
    {
        var payload = new _0Payload();
        var result = _client.ProfileSecurityService.PostProfilesecurityAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutProfileSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ProfileSecurityService.PutProfilesecurityAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteProfileSecurityAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ProfileSecurityService.DeleteProfilesecurityAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetProfileSecurityByInternalIdAsync()
    {
        var result = _client.ProfileSecurityService
            .GetProfilesecurityByInternalIdAsync(null, null, null, null, null, null, null, null, null, null, InternalId)
            .Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void PutProfileSecurityByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ProfileSecurityService
            .PutProfilesecurityByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteProfileSecurityByIdAsync()
    {
        var internalId = string.Empty;
        var payload = new _0Payload();
        var result = _client.ProfileSecurityService
            .DeleteProfilesecurityByIdAsync(null, null, null, null, null, internalId, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}