using Transact;
using Transact.Party.ExternalUsers;

namespace OpenTemenos.Tests.Transact.Party;

[TestClass]
public class ExternalUsersServiceTests : CredentialManagement
{
    private const string ExternalUserPreferencesId = "1";
    private readonly IPartyClient _client = new PartyClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetExternalUserProfileAsync()
    {
        var result = _client.ExternalUsersService.GetExternalUserProfileAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetExternalUserPreferencesAsync()
    {
        var result = _client.ExternalUsersService.GetExternalUserPreferencesAsync()
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateExternalUserStatusAsync()
    {
        var externalUserId = string.Empty;
        var payload = new ExternalUserStatus();
        var result = _client.ExternalUsersService.UpdateExternalUserStatusAsync(externalUserId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("POST method")]
    public void CreateExternalUserPreferenceAsync()
    {
        var externalUserPreferencesId = string.Empty;
        var payload = new ExternalUserPreference();
        var result = _client.ExternalUsersService.CreateExternalUserPreferenceAsync(externalUserPreferencesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("PUT method")]
    public void UpdateExternalUserPreferenceAsync()
    {
        var externalUserPreferencesId = string.Empty;
        var payload = new ExternalUserPreference();
        var result = _client.ExternalUsersService.UpdateExternalUserPreferenceAsync(externalUserPreferencesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    [Ignore("DELETE method")]
    public void DeleteExternalUserPreferenceAsync()
    {
        var externalUserPreferencesId = string.Empty;
        var payload = new ExternalUserPreferenceDelete();
        var result = _client.ExternalUsersService.DeleteExternalUserPreferenceAsync(externalUserPreferencesId, payload)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }

    [TestMethod]
    public void GetExternalUserPreferenceAsync()
    {
        var result = _client.ExternalUsersService.GetExternalUserPreferenceAsync(ExternalUserPreferencesId)
            .Result;
        Assert.IsNotNull(result.Body);
        Debug.WriteLine($@"Sample: {JsonSerializer.Serialize(result.Body)}");
    }
}